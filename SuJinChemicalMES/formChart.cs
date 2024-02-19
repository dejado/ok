using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuJinChemicalMES
{
    public partial class formChart : Form
    {
        public formChart()
        {
            InitializeComponent();
        }

        private void formChart_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            //Load sample data
            var sampleData1 = new MLModel1.ModelInput()
            {
                VibrationNum = 1.3188805F,
                HeightNum = 500.3159F,
                VibrationBinary = 0F,
                HeightBinary = 0F,
            };
            var sampleData2 = new MLModel1.ModelInput()
            {
                VibrationNum = 0.3188805F,
                HeightNum = 500.3159F,
                VibrationBinary = 1F,
                HeightBinary = 0F,
            };
            var sampleData3 = new MLModel1.ModelInput()
            {
                VibrationNum = 1.3188805F,
                HeightNum = 500.3159F,
                VibrationBinary = 1F,
                HeightBinary = 0F,
            };
            var sampleData4 = new MLModel1.ModelInput()
            {
                VibrationNum = 0.3188805F,
                HeightNum = 575.3159F,
                VibrationBinary = 0F,
                HeightBinary = 0F,
            };
            var sampleData5 = new MLModel1.ModelInput()
            {
                VibrationNum = 0.3188805F,
                HeightNum = 575.3159F,
                VibrationBinary = 0F,
                HeightBinary = 1F,
            };
            var sampleData6 = new MLModel1.ModelInput()
            {
                VibrationNum = 0.3188805F,
                HeightNum = 500.3159F,
                VibrationBinary = 0F,
                HeightBinary = 0F,
            };



            var sampleData12 = new MLModel2.ModelInput()
            {
                VibrationNum = 1.3188805F,
                HeightNum = 500.3159F,
                VibrationBinary = 0F,
                HeightBinary = 0F,
            };
            var sampleData11 = new MLModel2.ModelInput()
            {
                VibrationNum = 0.3188805F,
                HeightNum = 500.3159F,
                VibrationBinary = 1F,
                HeightBinary = 0F,
            };
            var sampleData10 = new MLModel2.ModelInput()
            {
                VibrationNum = 1.3188805F,
                HeightNum = 500.3159F,
                VibrationBinary = 1F,
                HeightBinary = 0F,
            };
            var sampleData9 = new MLModel2.ModelInput()
            {
                VibrationNum = 0.3188805F,
                HeightNum = 575.3159F,
                VibrationBinary = 0F,
                HeightBinary = 0F,
            };
            var sampleData8 = new MLModel2.ModelInput()
            {
                VibrationNum = 0.3188805F,
                HeightNum = 575.3159F,
                VibrationBinary = 0F,
                HeightBinary = 1F,
            };
            var sampleData7 = new MLModel2.ModelInput()
            {
                VibrationNum = 0.3188805F,
                HeightNum = 500.3159F,
                VibrationBinary = 0F,
                HeightBinary = 0F,
            };
            //Load model and predict output
            var result1 = MLModel1.Predict(sampleData1);
            var result2 = MLModel1.Predict(sampleData2);
            var result3 = MLModel1.Predict(sampleData3);
            var result4 = MLModel1.Predict(sampleData4);
            var result5 = MLModel1.Predict(sampleData5);
            var result6 = MLModel1.Predict(sampleData6);

            var result12 = MLModel2.Predict(sampleData12);
            var result11 = MLModel2.Predict(sampleData11);
            var result10 = MLModel2.Predict(sampleData10);
            var result9 = MLModel2.Predict(sampleData9);
            var result8 = MLModel2.Predict(sampleData8);
            var result7 = MLModel2.Predict(sampleData7);

            label1.Text = result1.Score.ToString();
            label2.Text = result2.Score.ToString();
            label3.Text = result3.Score.ToString();
            label4.Text = result4.Score.ToString();
            label5.Text = result5.Score.ToString();
            label6.Text = result6.Score.ToString();


            string machine1 = result12.Score.ToString();
            string machine2 = result11.Score.ToString();
            string machine3 = result10.Score.ToString();
            string machine4 = result9.Score.ToString();
            string machine5 = result8.Score.ToString();
            string machine6 = result7.Score.ToString();


            label12.Text = result12.Score.ToString();
            label11.Text = result11.Score.ToString();
            label10.Text = result10.Score.ToString();
            label9.Text = result9.Score.ToString();
            label8.Text = result8.Score.ToString();
            label7.Text = result7.Score.ToString();
        }

    }
}

