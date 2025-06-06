// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Instruct the system how to handle and charge the logs ingested to this table. </summary>
    public readonly partial struct OperationalInsightsTablePlan : IEquatable<OperationalInsightsTablePlan>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsTablePlan"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationalInsightsTablePlan(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string AnalyticsValue = "Analytics";

        /// <summary> Logs that are adjusted to support high volume low value verbose logs. </summary>
        public static OperationalInsightsTablePlan Basic { get; } = new OperationalInsightsTablePlan(BasicValue);
        /// <summary> Logs  that allow monitoring and analytics. </summary>
        public static OperationalInsightsTablePlan Analytics { get; } = new OperationalInsightsTablePlan(AnalyticsValue);
        /// <summary> Determines if two <see cref="OperationalInsightsTablePlan"/> values are the same. </summary>
        public static bool operator ==(OperationalInsightsTablePlan left, OperationalInsightsTablePlan right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationalInsightsTablePlan"/> values are not the same. </summary>
        public static bool operator !=(OperationalInsightsTablePlan left, OperationalInsightsTablePlan right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OperationalInsightsTablePlan"/>. </summary>
        public static implicit operator OperationalInsightsTablePlan(string value) => new OperationalInsightsTablePlan(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationalInsightsTablePlan other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationalInsightsTablePlan other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
