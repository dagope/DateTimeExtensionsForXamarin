﻿#region License

// 
// Copyright (c) 2011-2012, João Matos Silva <kappy@acydburne.com.pt>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DateTimeExtensionsXamarin.Common;

namespace DateTimeExtensionsXamarin.NaturalText.CultureStrategies
{
    [Locale("de-DE")]
    public class DE_DENaturalTimeStrategy : NaturalTimeStrategyBase
    {
        protected override string YearText
        {
            get { return "jahr"; }
        }

        protected override string MonthText
        {
            get { return "monat"; }
        }

        protected override string DayText
        {
            get { return "tag"; }
        }

        protected override string HourText
        {
            get { return "stunde"; }
        }

        protected override string MinuteText
        {
            get { return "minute"; }
        }

        protected override string SecondText
        {
            get { return "sekunde"; }
        }

        protected override string Pluralize(string text)
        {
            if (text.EndsWith("e"))
            {
                return text + "n";
            }
            return text + "en";
        }
    }
}