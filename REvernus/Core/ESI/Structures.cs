﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EVEStandard.Models;
using EVEStandard.Models.API;

namespace REvernus.Core.ESI
{
    public static class Structures
    {
        public static async Task<Structure> GetStructureInfoAsync(AuthDTO auth, long structureId, string searchString = "")
        {
            try
            {
                var structureInfo =
                    await EsiData.EsiClient.Universe.GetStructureInfoV2Async(auth, structureId);

                if (searchString == "") return structureInfo.Model;

                if (structureInfo.Model.Name.Contains(searchString))
                {
                    return structureInfo.Model;
                }
            }
            catch (Exception)
            {
                // Ignored
            }
            return null;
        }
    }
}
