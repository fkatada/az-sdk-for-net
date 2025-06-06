// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ComponentModel;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Incoming video stream out of sync event data. Schema of the data property of an EventGridEvent for a Microsoft.Media.LiveEventIncomingVideoStreamsOutOfSync event. </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class MediaLiveEventIncomingVideoStreamsOutOfSyncEventData
    {
        /// <summary> Initializes a new instance of <see cref="MediaLiveEventIncomingVideoStreamsOutOfSyncEventData"/>. </summary>
        internal MediaLiveEventIncomingVideoStreamsOutOfSyncEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaLiveEventIncomingVideoStreamsOutOfSyncEventData"/>. </summary>
        /// <param name="firstTimestamp"> Gets the first timestamp received for one of the quality levels. </param>
        /// <param name="firstDuration"> Gets the duration of the data chunk with first timestamp. </param>
        /// <param name="secondTimestamp"> Gets the timestamp received for some other quality levels. </param>
        /// <param name="secondDuration"> Gets the duration of the data chunk with second timestamp. </param>
        /// <param name="timescale"> Gets the timescale in which both the timestamps and durations are represented. </param>
        internal MediaLiveEventIncomingVideoStreamsOutOfSyncEventData(string firstTimestamp, string firstDuration, string secondTimestamp, string secondDuration, string timescale)
        {
            FirstTimestamp = firstTimestamp;
            FirstDuration = firstDuration;
            SecondTimestamp = secondTimestamp;
            SecondDuration = secondDuration;
            Timescale = timescale;
        }

        /// <summary> Gets the first timestamp received for one of the quality levels. </summary>
        public string FirstTimestamp { get; }
        /// <summary> Gets the duration of the data chunk with first timestamp. </summary>
        public string FirstDuration { get; }
        /// <summary> Gets the timestamp received for some other quality levels. </summary>
        public string SecondTimestamp { get; }
        /// <summary> Gets the duration of the data chunk with second timestamp. </summary>
        public string SecondDuration { get; }
        /// <summary> Gets the timescale in which both the timestamps and durations are represented. </summary>
        public string Timescale { get; }
    }
}
