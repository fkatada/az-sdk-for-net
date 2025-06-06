// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.Messages
{
    /// <summary> The type of a participant in a threaded conversation. </summary>
    internal readonly partial struct ParticipantKind : IEquatable<ParticipantKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ParticipantKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ParticipantKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InternalValue = "internal";
        private const string ExternalValue = "external";

        /// <summary> A participant internal to Azure Communication Services. </summary>
        public static ParticipantKind Internal { get; } = new ParticipantKind(InternalValue);
        /// <summary> A participant on other platforms. </summary>
        public static ParticipantKind External { get; } = new ParticipantKind(ExternalValue);
        /// <summary> Determines if two <see cref="ParticipantKind"/> values are the same. </summary>
        public static bool operator ==(ParticipantKind left, ParticipantKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ParticipantKind"/> values are not the same. </summary>
        public static bool operator !=(ParticipantKind left, ParticipantKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ParticipantKind"/>. </summary>
        public static implicit operator ParticipantKind(string value) => new ParticipantKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ParticipantKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ParticipantKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
