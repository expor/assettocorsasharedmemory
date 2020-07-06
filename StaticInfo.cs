using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssettoCorsaSharedMemory
{
    public class StaticInfoEventArgs : EventArgs
    {
        public StaticInfoEventArgs (StaticInfo staticInfo)
        {
            this.StaticInfo = staticInfo;
        }

        public StaticInfo StaticInfo { get; private set; }
    }

    [StructLayout (LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct StaticInfo
    {
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String SMVersion;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String ACVersion;
        public int NumberOfSessions;
        public int NumCars;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String CarModel;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String Track;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String PlayerName;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String PlayerSurname;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String PlayerNick;
        public int SectorCount;

        // UNUSED
        public float unused_MaxTorque;
        public float unused_MaxPower;

        public int MaxRpm;
        public float MaxFuel;

        // UNUSED
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] unused_SuspensionMaxTravel;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] unused_TyreRadius;
        public float unused_MaxTurboBoost;
        public float unused_Deprecated1; // AirTemp since 1.6 in physic
        public float unused_Deprecated2; // RoadTemp since 1.6 in physic

        public int PenaltiesEnabled;
        public float AidFuelRate;
        public float AidTireRate;
        public float AidMechanicalDamage;
        public int AidAllowTyreBlankets;
        public float AidStability;
        public int AidAutoClutch;
        public int AidAutoBlip;

        // UNUSED
        public int unused_HasDRS;
        public int unused_HasERS;
        public int unused_HasKERS;
        public float unused_KersMaxJoules;
        public int unused_EngineBrakeSettingsCount;
        public int unused_ErsPowerControllerCount;
        public float unused_TrackSplineLength;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public string unused_TrackConfiguration;
        public float unused_ErsMaxJ;
        public int unused_IsTimedRace;
        public int unused_HasExtraLap;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String unused_CarSkin;
        public int unused_ReversedGridPositions;

        public int PitWindowStart;
        public int PitWindowEnd;
        public int isOnline;
    }
}
