// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.ComponentModel;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Job Output Progress Event Data. Schema of the Data property of an EventGridEvent for a Microsoft.Media.JobOutputProgress event. </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class MediaJobOutputProgressEventData
    {
        /// <summary> Initializes a new instance of <see cref="MediaJobOutputProgressEventData"/>. </summary>
        internal MediaJobOutputProgressEventData()
        {
            JobCorrelationData = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobOutputProgressEventData"/>. </summary>
        /// <param name="label"> Gets the Job output label. </param>
        /// <param name="progress"> Gets the Job output progress. </param>
        /// <param name="jobCorrelationData"> Gets the Job correlation data. </param>
        internal MediaJobOutputProgressEventData(string label, long? progress, IReadOnlyDictionary<string, string> jobCorrelationData)
        {
            Label = label;
            Progress = progress;
            JobCorrelationData = jobCorrelationData;
        }

        /// <summary> Gets the Job output label. </summary>
        public string Label { get; }
        /// <summary> Gets the Job output progress. </summary>
        public long? Progress { get; }
        /// <summary> Gets the Job correlation data. </summary>
        public IReadOnlyDictionary<string, string> JobCorrelationData { get; }
    }
}
