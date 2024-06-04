// Implement the generated code based on the trained model of restaurant feedback/reviews

// Input data
using DotNet_MachineLearning;

var sampleData = new CustomModel.ModelInput()
{
    Col0 = "This restaurant was excellent."
};

// Load model and predict output
var result = CustomModel.Predict(sampleData);

// Result of 1 = "Positive" otherwise result of 0 = "Negative"
var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";

Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");
