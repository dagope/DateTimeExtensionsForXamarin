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
    [Locale("en-GB")]
    [Locale("en-US")]
    public class EN_GBNaturalTimeStrategy : NaturalTimeStrategyBase
    {
        protected override string YearText
        {
            get { return "year"; }
        }

        protected override string MonthText
        {
            get { return "month"; }
        }

        protected override string DayText
        {
            get { return "day"; }
        }

        protected override string HourText
        {
            get { return "hour"; }
        }

        protected override string MinuteText
        {
            get { return "minute"; }
        }

        protected override string SecondText
        {
            get { return "second"; }
        }
    }
}