using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ödev2
{
    public partial class Form1 : Form
    {
        private DataTable trainingData;
        private DataTable testData;
        private NaiveBayesClassifier classifier;

        public Form1()
        {
            InitializeComponent();

            // Initialize the DataTables for training and test data
            trainingData = new DataTable();
            testData = new DataTable();

            // Set the DataSource for the DataGridViews
            trainingDataGridView.DataSource = trainingData;
            testDataGridView.DataSource = testData;
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            // Get the training data from the DataGridView
            trainingData = (DataTable)trainingDataGridView.DataSource;

            // Create a Naive Bayes classifier and train it using the training data
            classifier = new NaiveBayesClassifier();
            classifier.Train(trainingData);
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            // Get the test data from the DataGridView
            testData = (DataTable)testDataGridView.DataSource;


            // Use the trained classifier to classify the test data
            DataTable classifiedData = classifier.Classify(testData);


            // Display the classified data in the DataGridView
            classifiedDataGridView.DataSource = classifiedData;

            // Loop through all the rows in the classified data
            int truePositives = 0;
            int trueNegatives = 0;
            int falsePositives = 0;
            int falseNegatives = 0;
            foreach (DataRow row in classifiedData.Rows)
            {
                // Get the predicted and true class labels for the row
                string predictedClass = row[classifiedData.Columns.Count - 1].ToString();
                string trueClass = row[classifiedData.Columns.Count - 2].ToString();

                // Update the true positive, true negative, false positive, and false negative counts
                if (predictedClass == "good" && trueClass == "good")
                {
                    truePositives++;
                }
                else if (predictedClass == "bad" && trueClass == "bad")
                {
                    trueNegatives++;
                }
                else if (predictedClass == "good" && trueClass == "bad")
                {
                    falsePositives++;
                }
                else if (predictedClass == "bad" && trueClass == "good")
                {
                    falseNegatives++;
                }
            }

            // Calculate the true positive rate
            int totalPositives = truePositives + falseNegatives;
            double truePositiveRate = (double)truePositives / totalPositives;

            // Calculate the true negative rate
            int totalNegatives = trueNegatives + falsePositives;
            double trueNegativeRate = (double)trueNegatives / totalNegatives;

            // Calculate the false positive rate
            double falsePositiveRate = (double)falsePositives / totalNegatives;

            // Calculate the false negative rate
            double falseNegativeRate = (double)falseNegatives / totalPositives;

            double accuracy = (double)(truePositives + trueNegatives) / (truePositives+trueNegatives+falseNegatives+falsePositives);

            label1.Text = $"{truePositives}";
            label2.Text = $"{trueNegatives}";
            label3.Text = $"{truePositiveRate}";
            label4.Text = $"{trueNegativeRate}";
            label5.Text = $"{accuracy}";
            label13.Text = $"{falsePositives}";
            label14.Text = $"{falseNegatives}";
            label17.Text = $"{falsePositiveRate}";
            label18.Text = $"{falseNegativeRate}";
        }
        
        public class NaiveBayesClassifier
        {
            // Define the dataByClass and probabilities variables as member variables of the class
            private Dictionary<string, List<List<string>>> dataByClass;
            private Dictionary<string, Dictionary<string, Dictionary<string, double>>> probabilities;
            private List<string[]> possibleAttributeValues;
            // Initialize the dataByClass variable in the constructor
            public NaiveBayesClassifier()
            {
                // Initialize the dataByClass variable
                dataByClass = new Dictionary<string, List<List<string>>>();
                // Initialize the probabilities variable
                probabilities = new Dictionary<string, Dictionary<string, Dictionary<string, double>>>();
            }

            // Train the classifier using the input data
            public void Train(DataTable data)
            {


                // TODO: Implement training of the classifier using the input data
                // Store the input data in a dictionary, where the key is the class label
                // and the value is a list of the attribute values for that class



                // Loop through all the rows in the input DataTable
                foreach (DataRow row in data.Rows)
                {
                    // Get the class label and attribute values for the row
                    string classLabel = row[data.Columns.Count - 1].ToString();
                    string[] attributeValues = row.ItemArray.Cast<string>().ToArray();

                    // Convert the attribute values to a List<string>
                    List<string> attributeValuesList = attributeValues.ToList();

                    // Add the attribute values to the dictionary
                    if (!dataByClass.ContainsKey(classLabel))
                    {
                        dataByClass.Add(classLabel, new List<List<string>>());
                    }
                    dataByClass[classLabel].Add(attributeValuesList);
                }

                // Create a list of all the possible values for each attribute
                List<string[]> possibleAttributeValues = new List<string[]>();
                for (int i = 0; i < data.Columns.Count - 1; i++)
                {
                    possibleAttributeValues.Add(data.AsEnumerable()
                                                   .Select(r => r[i].ToString())
                                                   .Distinct()
                                                   .ToArray());
                }



                // Calculate the probabilities for each class and each attribute value
                probabilities = new Dictionary<string, Dictionary<string, Dictionary<string, double>>>();
                foreach (string classValue in dataByClass.Keys)
                {
                    // Calculate the prior probability for this class
                    double classProbability = (double)dataByClass[classValue].Count / data.Rows.Count;

                    // Initialize the inner dictionary
                    probabilities[classValue] = new Dictionary<string, Dictionary<string, double>>();

                    // Loop through all the attributes
                    for (int i = 0; i < data.Columns.Count - 1; i++)
                    {
                        // Initialize the innermost dictionary
                        probabilities[classValue][data.Columns[i].ColumnName] = new Dictionary<string, double>();

                        // Get the possible values for this attribute
                        string[] possibleAttributeValuesForClass = possibleAttributeValues[i];

                        // Loop through each possible attribute value
                        foreach (string attributeValue in possibleAttributeValuesForClass)
                        {
                            // Check if the current attribute value is numeric
                            bool isNumeric = double.TryParse(attributeValue, out double _);

                            // Calculate the probability for this attribute value
                            double probability;
                            if (isNumeric)
                            {
                                // For numeric attributes, calculate the mean and standard deviation for the attribute values in this class
                                double mean = dataByClass[classValue].Select(x => double.Parse(x[i])).Average();
                                double standardDeviation = Math.Sqrt(dataByClass[classValue].Select(x => double.Parse(x[i])).Average(x => Math.Pow(x - mean, 2)));

                                // Use the calculated mean and standard deviation to calculate the probability using a normal distribution
                                probability = CalculateNormalDistributionProbability(attributeValue, mean, standardDeviation);
                            }
                            else
                            {
                                // For categorical attributes, calculate the probability as the number of times the attribute value occurs in this class divided by the total number of rows in this class
                                probability = (double)dataByClass[classValue].Count(x => x[i] == attributeValue) / dataByClass[classValue].Count;
                            }

                            // Store the calculated probability in the probabilities dictionary
                            probabilities[classValue][data.Columns[i].ColumnName][attributeValue] = probability;
                        }
                    }
                }
            }
            // Use the trained classifier to classify the input data
            public DataTable Classify(DataTable data)
            {


                // Create a new DataTable to store the classified data
                DataTable classifiedData = new DataTable();
                

                // Add a column to the DataTable for each attribute in the input data,
                // plus one additional column for the predicted class label
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    classifiedData.Columns.Add(data.Columns[i].ColumnName);
                    
                }
                classifiedData.Columns.Add("PredictedClass");

               


                // Loop through all the rows in the input data
                foreach (DataRow row in data.Rows)
                {
                    
                    // Create a dictionary to store the probabilities for each class
                    Dictionary<string, double> classProbabilities = new Dictionary<string, double>();
                    
                    // Loop through all the classes
                    foreach (string classValue in dataByClass.Keys)
                    {
                        
                        // Set the initial probability for the class to 1
                        classProbabilities.Add(classValue, 1);

                        // Loop through all the attributes in the input data
                        for (int i = 0; i < data.Columns.Count-1; i++)
                        {
                            // Get the attribute value for the current row
                            string attributeValue = row[i].ToString();
                            
                            // Check if the attribute is numeric or not
                            bool isNumeric = double.TryParse(attributeValue, out _);

                            // Calculate the probability for the attribute value
                            // using the appropriate calculation for the data type
                            double probability;
                            if (isNumeric)
                            {
                                // For numeric attributes, calculate the mean and standard deviation for the attribute values in this class
                                double mean = dataByClass[classValue].Select(x => double.Parse(x[i])).Average();
                                double standardDeviation = Math.Sqrt(dataByClass[classValue].Select(x => double.Parse(x[i])).Average(x => Math.Pow(x - mean, 2)));

                                // Use the calculated mean and standard deviation to calculate the probability using a normal distribution
                                probability = CalculateNormalDistributionProbability(attributeValue, mean, standardDeviation);
                            }
                            else
                            {
                                // For categorical attributes, use the probabilities stored in the dictionary
                                probability = probabilities[classValue][data.Columns[i].ColumnName][attributeValue];
                            }

                            // Update the probability for the class using the calculated probability for the attribute value
                            classProbabilities[classValue] *= probability;
                        }
                    }
                    
                    // Select the class with the highest probability as the predicted class for the current row
                    string predictedClass = classProbabilities.OrderByDescending(kvp => kvp.Value).First().Key;

                    // Create a new DataRow to store the classified data for the current row
                    DataRow classifiedRow = classifiedData.NewRow();

                    // Add the attribute values and predicted class to the DataRow
                    for (int i = 0; i < data.Columns.Count; i++)
                    {
                        classifiedRow[i] = row[i];
                    }
                    classifiedRow[data.Columns.Count] = predictedClass;

                    // Add the classified DataRow to the DataTable
                    classifiedData.Rows.Add(classifiedRow);
                }

                // Return the classified DataTable
                return classifiedData;
            }

            private double CalculateNormalDistributionProbability(string attributeValue, double mean, double standardDeviation)
            {
                // Calculate the probability using a normal distribution
                double value = double.Parse(attributeValue);
                double exponent = Math.Exp(-Math.Pow(value - mean, 2) / (2 * Math.Pow(standardDeviation, 2)));
                return (1 / (standardDeviation * Math.Sqrt(2 * Math.PI))) * exponent;
            }
        }

        private void loadTrainingDataButton_Click(object sender, EventArgs e)
        {
        // Show the Open File dialog
        DialogResult result = openFileDialog1.ShowDialog();
        if (result != DialogResult.OK)
        {
            return;
        }

        // Get the selected file path
        string filePath = openFileDialog1.FileName;

        // Read the CSV file and populate the DataTable
        trainingData = ReadCsv(filePath);

        // Set the DataSource for the trainingDataGridView
        trainingDataGridView.DataSource = trainingData;
        }

        private void loadTestDataButton_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog
            DialogResult result = openFileDialog2.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            // Get the selected file path
            string filePath = openFileDialog2.FileName;

            // Read the CSV file and populate the DataTable
            testData = ReadCsv(filePath);

            // Set the DataSource for the testDataGridView
            testDataGridView.DataSource = testData;


        }
        // Read the CSV file at the specified path and return a DataTable
        private DataTable ReadCsv(string filePath)
        {
            // Create a DataTable to store the data
            DataTable dataTable = new DataTable();

            // Read the file
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Get the column names from the first line
                string[] columnNames = reader.ReadLine().Split(',');

                // Add the columns to the DataTable
                foreach (string columnName in columnNames)
                {
                    dataTable.Columns.Add(columnName);
                }

                // Read the remaining lines and add the data to the DataTable
                while (!reader.EndOfStream)
                {
                    // Get the data for the next line
                    string[] values = reader.ReadLine().Split(',');

                    // Add the values to a new row in the DataTable
                    dataTable.Rows.Add(values);
                }
            }
            // Delete rows that contain the value "?"
            for (int i = dataTable.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = dataTable.Rows[i];
                if (Enumerable.Contains(row.ItemArray,"?"))
                {
                    row.Delete();
                }
            }
            return dataTable;
        }
    }
}
