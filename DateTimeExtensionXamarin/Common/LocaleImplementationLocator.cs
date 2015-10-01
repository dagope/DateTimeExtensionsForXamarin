﻿
#region License

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
using System.Linq;
using System.Reflection;

namespace DateTimeExtensionsXamarin.Common
{
    public static class LocaleImplementationLocator
    {

        public static T FindImplementationOf<T>(string locale)
        {
            var type = typeof(T);


            var currentDomain = typeof(string).GetTypeInfo().Assembly.GetType("System.AppDomain").GetRuntimeProperty("CurrentDomain").GetMethod.Invoke(null, new object[] { });
            var getAssemblies = currentDomain.GetType().GetRuntimeMethod("GetAssemblies", new Type[] { });
            var assemblies = getAssemblies.Invoke(currentDomain, new object[] { }) as Assembly[];
            var allTypes = assemblies.SelectMany(a => a.DefinedTypes);

            var types = allTypes.Where(p => p.GetCustomAttributes(typeof(LocaleAttribute), false)
                                            .Any( a =>
                                                    ((LocaleAttribute)a).Locale.Equals(locale)));

            var implementationType = types.FirstOrDefault();
            if (implementationType == null)
            {
                return default(T);
            }

            var instance = (T)Activator.CreateInstance(implementationType.AsType());
            if (instance == null)
            {
                //throw new StrategyNotFoundException(string.Format("Could not create a new instance of type '{0}'.", typeName));
                return default(T);
            }
            return instance;
        }

        /*
        public static T FindImplementationOf<T>(string locale)
        {
            var type = typeof (T);     
                   
            var types = AppDomain.CurrentDomain.GetAssemblies().ToList()
                .SelectMany(GetTypesFromAssemblySafe).Where(p => type.IsAssignableFrom(p) &&
                                                                 p.GetCustomAttributes(typeof (LocaleAttribute), false)
                                                                     .Any(
                                                                         a =>
                                                                             ((LocaleAttribute) a).Locale.Equals(locale)));

            var implementationType = types.FirstOrDefault();
            if (implementationType == null)
            {
                return default(T);
            }

            var instance = (T) Activator.CreateInstance(implementationType);
            if (instance == null)
            {
                //throw new StrategyNotFoundException(string.Format("Could not create a new instance of type '{0}'.", typeName));
                return default(T);
            }
            return instance;
        }

        private static Type[] GetTypesFromAssemblySafe(Assembly assembly)
        {
            try
            {
                return assembly.ExportedTypes.ToArray();
            }
            catch
            {
                return new Type[] {};
            }
        }

        */
    }
}
