﻿
namespace WorkerAnt.Library
{
    /// <summary>
    /// Name of default laps available to be used. 
    /// </summary>
    public enum LapPackageNames
    {
        Manual,
        Recovery,
        Smart,
        Progress
    }
    /// <summary>
    /// Names of segments of a lap.
    /// </summary>
    public enum SegmentNames
    {
        Paused,
        Work,
        Break,
        EndBreak
    }
    /// <summary>
    /// Names of windows available to be opened.
    /// </summary>
    public enum WindowNames
    {
        Info,
        Settings,
        Break,
        ToBreak,
        Main
    }
}
