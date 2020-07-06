using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssettoCorsaSharedMemory
{
    public enum ACC_FLAG_TYPE
    {
        NO_FLAG,
        BLUE_FLAG,
        YELLOW_FLAG,
        BLACK_FLAG,
        WHITE_FLAG,
        CHECKERED_FLAG,
        PENALTY_FLAG,
        GREEN_FLAG,
        ORANGE_FLAG
    }

    public enum ACC_PENALTY_TYPE
    {
        None,
        DriveThrough_Cutting,
        StopAndGo_10_Cutting,
        StopAndGo_20_Cutting,
        StopAndGo_30_Cutting,
        Disqualified_Cutting,
        RemoveBestLaptime_Cutting,
        DriveThrough_PitSpeeding,
        StopAndGo_10_PitSpeeding,
        StopAndGo_20_PitSpeeding,
        StopAndGo_30_PitSpeeding,
        Disqualified_PitSpeeding,
        RemoveBestLaptime_PitSpeeding,
        Disqualified_IgnoredMandatoryPit,
        PostRaceTime,
        Disqualified_Trolling,
        Disqualified_PitEntry,
        Disqualified_PitExit,
        Disqualified_WrongWay,
        DriveThrough_IgnoredDriverStint,
        Disqualified_IgnoredDriverSting,
        Disqualified_ExceededDriverStintLimit
    }

    public enum ACC_STATUS
    {
        OFF,
        REPLAY,
        LIVE,
        PAUSE
    }

    public enum ACC_SESSION_TYPE
    {
        UNKNOWN = -1,
        PRACTICE,
        QUALIFY,
        RACE,
        HOTLAP,
        TIME_ATTACK,
        DRIFT,
        DRAG,
        HOTSTINT,
        HOTSTINTSUPERPOLE
    }

    public class GraphicsEventArgs : EventArgs
    {
        public GraphicsEventArgs (Graphics graphics)
        {
            this.Graphics = graphics;
        }

        public Graphics Graphics { get; private set; }
    }

    [StructLayout (LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct Graphics
    {
        public int PacketId;
        public ACC_STATUS Status;
        public ACC_SESSION_TYPE Session;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String CurrentTime;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String LastTime;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String BestTime;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 15)]
        public String Split;
        public int CompletedLaps;
        public int Position;
        public int iCurrentTime;
        public int iLastTime;
        public int iBestTime;
        public float SessionTimeLeft;
        public float DistanceTraveled;
        public int IsInPit;
        public int CurrentSectorIndex;
        public int LastSectorTime;
        public int NumberOfLaps;
        [MarshalAs (UnmanagedType.ByValTStr, SizeConst = 33)]
        public String TyreCompound;

        // UNUSED
        public float unused_ReplayTimeMultiplier;

        public float NormalizedCarPosition;
        public int ActiveCars;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 60)]
        public Coordinates[] CarCoordinates;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public int[] CarIdList;
        public int playerCarId;
        public float PenaltyTime;
        public ACC_FLAG_TYPE Flag;
        public ACC_PENALTY_TYPE Penalty;
        public int IdealLineOn;
        public int IsInPitLane;
        public float SurfaceGrip;
        public int MandatoryPitDone;

        public float WindSpeed;
        public float WindDirection;
        public int IsSetupMenuVisible;
        public int MainDisplayIndex;
        public int SecondaryDisplayIndex;
        public int TC1;
        public int TC2;
        public int EngineMap;
        public int ABS;
        public float FuelPerLap;
        public int RainLights;
        public int FlashingLights;
        public int LightStage;
        public float ExhaustTemperature;
        public int WiperMode;
        public int DriverStintTotalTimeLeft;
        public int DriverStintTimeLeft;
        public int RainTyres;
        public int SessionIndex;
        public float UsedFuel;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public String DeltaLapTimeString;
        public int DeltaLapTimeMs;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public String EstimatedLapTimeString;
        public int EstimatedLapTimeMs;
        public int IsDeltaPositive;
        public int LastSplitMs;
        public int IsValidLap;
        public float FuelEstimatedLaps;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public String TrackStatus;
        public int MissingMandatoryPits;
        public float Clock;
    }
}
