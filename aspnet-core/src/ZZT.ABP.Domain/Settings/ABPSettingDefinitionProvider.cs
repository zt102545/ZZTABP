﻿using Volo.Abp.Settings;

namespace ZZT.ABP.Settings
{
    public class ABPSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ABPSettings.MySetting1));
        }
    }
}
