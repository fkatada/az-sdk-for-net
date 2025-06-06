// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ComponentModel;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Encoder connect event data. Schema of the data property of an EventGridEvent for a Microsoft.Media.LiveEventEncoderConnected event. </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public partial class MediaLiveEventEncoderConnectedEventData
    {
        /// <summary> Initializes a new instance of <see cref="MediaLiveEventEncoderConnectedEventData"/>. </summary>
        internal MediaLiveEventEncoderConnectedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaLiveEventEncoderConnectedEventData"/>. </summary>
        /// <param name="ingestUrl"> Gets the ingest URL provided by the live event. </param>
        /// <param name="streamId"> Gets the stream Id. </param>
        /// <param name="encoderIp"> Gets the remote IP. </param>
        /// <param name="encoderPort"> Gets the remote port. </param>
        internal MediaLiveEventEncoderConnectedEventData(string ingestUrl, string streamId, string encoderIp, string encoderPort)
        {
            IngestUrl = ingestUrl;
            StreamId = streamId;
            EncoderIp = encoderIp;
            EncoderPort = encoderPort;
        }

        /// <summary> Gets the ingest URL provided by the live event. </summary>
        public string IngestUrl { get; }
        /// <summary> Gets the stream Id. </summary>
        public string StreamId { get; }
        /// <summary> Gets the remote IP. </summary>
        public string EncoderIp { get; }
        /// <summary> Gets the remote port. </summary>
        public string EncoderPort { get; }
    }
}
