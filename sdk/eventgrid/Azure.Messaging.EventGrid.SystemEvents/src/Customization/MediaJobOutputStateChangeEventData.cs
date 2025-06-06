// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.ComponentModel;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Media.JobOutputStateChange event. </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class MediaJobOutputStateChangeEventData
    {
        /// <summary> Initializes a new instance of <see cref="MediaJobOutputStateChangeEventData"/>. </summary>
        internal MediaJobOutputStateChangeEventData()
        {
            JobCorrelationData = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobOutputStateChangeEventData"/>. </summary>
        /// <param name="previousState"> The previous state of the Job. </param>
        /// <param name="output">
        /// Gets the output.
        /// Please note <see cref="MediaJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MediaJobOutputAsset"/>.
        /// </param>
        /// <param name="jobCorrelationData"> Gets the Job correlation data. </param>
        internal MediaJobOutputStateChangeEventData(MediaJobState? previousState, MediaJobOutput output, IReadOnlyDictionary<string, string> jobCorrelationData)
        {
            PreviousState = previousState;
            Output = output;
            JobCorrelationData = jobCorrelationData;
        }

        /// <summary> The previous state of the Job. </summary>
        public MediaJobState? PreviousState { get; }
        /// <summary>
        /// Gets the output.
        /// Please note <see cref="MediaJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MediaJobOutputAsset"/>.
        /// </summary>
        public MediaJobOutput Output { get; }
        /// <summary> Gets the Job correlation data. </summary>
        public IReadOnlyDictionary<string, string> JobCorrelationData { get; }
    }
}
