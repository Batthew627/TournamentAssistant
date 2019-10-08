﻿using System;
using System.Collections.Generic;
using static TournamentAssistantShared.SharedConstructs;

namespace TournamentAssistantShared.Models
{
    [Serializable]

    public class Match
    {
        public string Guid { get; set; }
        public Player[] Players { get; set; }
        public MatchCoordinator Coordinator { get; set; }

        //The following are created and modified by the match coordinator
        public PreviewBeatmapLevel CurrentlySelectedMap { get; set; }
        public Characteristic CurrentlySelectedCharacteristic { get; set; }
        public BeatmapDifficulty CurrentlySelectedDifficulty { get; set; }

        #region Equality
        public static bool operator ==(Match a, Match b)
        {
            if (ReferenceEquals(b, null)) return false;
            return a.GetHashCode() == b.GetHashCode();
        }

        public static bool operator !=(Match a, Match b)
        {
            if (b == null) return false;
            return a.GetHashCode() != b.GetHashCode();
        }

        public override bool Equals(object other)
        {
            if (!(other is Match)) return false;
            return GetHashCode() == (other as Match).GetHashCode();
        }

        public override int GetHashCode()
        {
            var hashCode = 1119573122;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Guid);
            return hashCode;
        }
        #endregion Equality
    }
}