﻿/****************************************************************************
 * NVorbis                                                                  *
 * Copyright (C) 2012, Andrew Ward <afward@gmail.com>                       *
 *                                                                          *
 * See COPYING for license terms (Ms-PL).                                   *
 *                                                                          *
 ***************************************************************************/
using System;

namespace NVorbis
{
    public interface IVorbisStreamStatus
    {
        /// <summary>
        /// Resets the counters for latency & bitrate calculations, as well as overall bit counts
        /// </summary>
        void ResetStats();

        /// <summary>
        /// Returns the calculated bit rate of audio stream data for the everything decoded so far
        /// </summary>
        int EffectiveBitRate { get; }

        /// <summary>
        /// Returns the calculated bit rate for the last ~1 second of audio
        /// </summary>
        int InstantBitRate { get; }

        /// <summary>
        /// Gets the calculated latency per page
        /// </summary>
        TimeSpan PageLatency { get; }

        /// <summary>
        /// Gets the calculated latency per packet
        /// </summary>
        TimeSpan PacketLatency { get; }

        /// <summary>
        /// Gets the calculated latency per second of output
        /// </summary>
        TimeSpan SecondLatency { get; }

        /// <summary>
        /// Gets the number of bits read that do not contribute to the output audio
        /// </summary>
        long OverheadBits { get; }

        /// <summary>
        /// Gets the number of bits read that contribute to the output audio
        /// </summary>
        long AudioBits { get; }

        /// <summary>
        /// Gets the number of pages read so far in the current stream
        /// </summary>
        int PagesRead { get; }

        /// <summary>
        /// Returns the total number of pages in the current stream
        /// </summary>
        int TotalPages { get; }
    }
}
