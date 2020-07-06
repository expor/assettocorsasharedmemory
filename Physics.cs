using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssettoCorsaSharedMemory
{
    public class PhysicsEventArgs : EventArgs
    {
        public PhysicsEventArgs (Physics physics)
        {
            this.Physics = physics;
        }

        public Physics Physics { get; private set; }
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct Coordinates
    {
        public float X;
        public float Y;
        public float Z;
    }

    [StructLayout (LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct Physics
    {
        public int PacketId;
        public float Gas;
        public float Brake;
        public float Fuel;
        public int Gear;
        public int Rpm;
        public float SteerAngle;
        public float SpeedKmh;

        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] Velocity;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] AccelerationG;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] WheelSlip;

        // UNUSED
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] unused_WheelLoad;

        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] WheelsPressure;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] WheelAngularSpeed;

        // UNUSED
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] unused_TyreWear;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] unused_TyreDirtyLevel;

        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] TyreCoreTemperature;

        // UNUSED
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] unused_CamberRad;

        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] SuspensionTravel;

        // UNUSED
        public float unused_Drs;

        public float TCActive;
        public float Heading;
        public float Pitch;
        public float Roll;

        // UNUSED
        public float unused_CgHeight;

        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 5)]
        public float[] CarDamage;

        // UNUSED
        public int unused_NumberOfTyresOut;

        public int PitLimiterOn;
        public float ABSActive;

        // UNUSED
        public float unused_KersCharge;
        public float unused_KersInput;

        public int AutoShifterOn;

        // UNUSED
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 2)]
        public float[] unused_RideHeight;

        public float TurboBoost;
        
        // UNUSED
        public float unused_Ballast;
        public float unused_AirDensity;

        public float AirTemp;
        public float RoadTemp;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] LocalAngularVelocity;
        public float FinalFF;

        // UNUSED
        public float unused_PerformanceMeter;
        public int unused_EngineBrake;
        public int unused_ErsRecoveryLevel;
        public int unused_ErsPowerLevel;
        public int unused_ErsHeatCharging;
        public int unused_ErsisCharging;
        public float unused_KersCurrentKJ;
        public int unused_DrsAvailable;
        public int unused_DrsEnabled;

        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] BrakeTemp;
        public float Clutch;

        // UNUSED
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] unused_TyreTempI;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] unused_TyreTempM;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] unused_TyreTempO;

        public int IsAIControlled;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public Coordinates[] TyreContactPoint;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public Coordinates[] TyreContactNormal;
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 4)]
        public Coordinates[] TyreContactHeading;
        public float BrakeBias; // TODO: Dash offset, how does it affect?
        [MarshalAs (UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] LocalVelocity;

        // UNUSED
        public int unused_P2PActivation;
        public int unused_P2PStatus;
        public float unused_CurrentMaxRpm;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] unused_mz;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] unused_fx;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] unused_fy;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] unused_SlipRatio;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] unused_SlipAngle;
        public int unused_TCInAction;
        public int unused_ABSInAction;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] unused_SuspensionDamage;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] unused_TyreTemperature;

        public float WaterTemperature;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] BrakePressure;
        public int FrontBrakeCompound;
        public int rearBrakeCompound;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] BrakePadLife;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] BrakeDiscLife;
    }
}
