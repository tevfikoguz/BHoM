﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BH.oM.Base;
using BH.oM.Environment.Elements;

namespace BH.oM.Environment.Interface
{
    public interface IMaterial: IBHoMObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        IMaterialProperties MaterialProperties { get; set; }

        /***************************************************/
    }
}