﻿// This file was auto-generated by ML.NET Model Builder.
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace SuJinChemicalMES
{
    public partial class MLModel2
    {
        /// <summary>
        /// model input class for MLModel2.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [LoadColumn(0)]
            [ColumnName(@"VibrationNum")]
            public float VibrationNum { get; set; }

            [LoadColumn(1)]
            [ColumnName(@"HeightNum")]
            public float HeightNum { get; set; }

            [LoadColumn(2)]
            [ColumnName(@"VibrationBinary")]
            public float VibrationBinary { get; set; }

            [LoadColumn(3)]
            [ColumnName(@"HeightBinary")]
            public float HeightBinary { get; set; }

            [LoadColumn(4)]
            [ColumnName(@"BinaryValues")]
            public float BinaryValues { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for MLModel2.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"VibrationNum")]
            public float VibrationNum { get; set; }

            [ColumnName(@"HeightNum")]
            public float HeightNum { get; set; }

            [ColumnName(@"VibrationBinary")]
            public float VibrationBinary { get; set; }

            [ColumnName(@"HeightBinary")]
            public float HeightBinary { get; set; }

            [ColumnName(@"BinaryValues")]
            public float BinaryValues { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"Score")]
            public float Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("MLModel2.mlnet");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);


        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

    }
}