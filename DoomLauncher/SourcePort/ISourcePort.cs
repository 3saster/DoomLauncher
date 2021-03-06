﻿using DoomLauncher.Interfaces;
using DoomLauncher.SaveGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoomLauncher.SourcePort
{
    public interface ISourcePort
    {
        string IwadParameter(SpData data);
        string FileParameter(SpData data);
        string WarpParameter(SpData data);
        string SkillParameter(SpData data);
        string RecordParameter(SpData data);
        string PlayDemoParameter(SpData data);

        bool Supported(); //if the exe is supported by this implementation
        bool StatisticsSupported();
        IStatisticsReader CreateStatisticsReader(IGameFile gameFile, IEnumerable<IStatsData> existingStats);
        ISaveGameReader CreateSaveGameReader(FileInfo file);
    }
}
