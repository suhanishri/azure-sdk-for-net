// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Primary metrics for classification tasks. </summary>
    public readonly partial struct ClassificationPrimaryMetrics : IEquatable<ClassificationPrimaryMetrics>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClassificationPrimaryMetrics"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClassificationPrimaryMetrics(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AUCWeightedValue = "AUCWeighted";
        private const string AccuracyValue = "Accuracy";
        private const string NormMacroRecallValue = "NormMacroRecall";
        private const string AveragePrecisionScoreWeightedValue = "AveragePrecisionScoreWeighted";
        private const string PrecisionScoreWeightedValue = "PrecisionScoreWeighted";

        /// <summary>
        /// AUC is the Area under the curve.
        /// This metric represents arithmetic mean of the score for each class,
        /// weighted by the number of true instances in each class.
        /// </summary>
        public static ClassificationPrimaryMetrics AUCWeighted { get; } = new ClassificationPrimaryMetrics(AUCWeightedValue);
        /// <summary> Accuracy is the ratio of predictions that exactly match the true class labels. </summary>
        public static ClassificationPrimaryMetrics Accuracy { get; } = new ClassificationPrimaryMetrics(AccuracyValue);
        /// <summary>
        /// Normalized macro recall is recall macro-averaged and normalized, so that random
        /// performance has a score of 0, and perfect performance has a score of 1.
        /// </summary>
        public static ClassificationPrimaryMetrics NormMacroRecall { get; } = new ClassificationPrimaryMetrics(NormMacroRecallValue);
        /// <summary>
        /// The arithmetic mean of the average precision score for each class, weighted by
        /// the number of true instances in each class.
        /// </summary>
        public static ClassificationPrimaryMetrics AveragePrecisionScoreWeighted { get; } = new ClassificationPrimaryMetrics(AveragePrecisionScoreWeightedValue);
        /// <summary> The arithmetic mean of precision for each class, weighted by number of true instances in each class. </summary>
        public static ClassificationPrimaryMetrics PrecisionScoreWeighted { get; } = new ClassificationPrimaryMetrics(PrecisionScoreWeightedValue);
        /// <summary> Determines if two <see cref="ClassificationPrimaryMetrics"/> values are the same. </summary>
        public static bool operator ==(ClassificationPrimaryMetrics left, ClassificationPrimaryMetrics right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClassificationPrimaryMetrics"/> values are not the same. </summary>
        public static bool operator !=(ClassificationPrimaryMetrics left, ClassificationPrimaryMetrics right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClassificationPrimaryMetrics"/>. </summary>
        public static implicit operator ClassificationPrimaryMetrics(string value) => new ClassificationPrimaryMetrics(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClassificationPrimaryMetrics other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClassificationPrimaryMetrics other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
