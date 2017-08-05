﻿/*
  TASrvSchema.cs -- stored schema for formating of the 'DrTASrv', July 29, 2017
 
  Copyright (c) 2013-2017 Kudryashov Andrey aka Dr
 
  This software is provided 'as-is', without any express or implied
  warranty. In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

      1. The origin of this software must not be misrepresented; you must not
      claim that you wrote the original software. If you use this software
      in a product, an acknowledgment in the product documentation would be
      appreciated but is not required.

      2. Altered source versions must be plainly marked as such, and must not be
      misrepresented as being the original software.

      3. This notice may not be removed or altered from any source distribution.

      Kudryashov Andrey <kudryashov.andrey at gmail.com>

 */

using System;

namespace DrOpen.DrTest.DrTASrv
{
    public class TASrvSchema
    {

        public const string AttrServerName = "ServerName";
        public const string DefaultServerName = "";

        public const string AttrServiceName = "ServiceName";
        public const string AttrTimeOut = "TimeOut";
        public const int DefaultTimeOut  = 90 ;

        public const string AttrSleepBetweenServiceAction = "SleepBetweenServiceAction";
        public const int DefaultSleepBetweenServiceAction = 0;

        public const string AttrServiceState = "ServiceState";

        public const string AttrPropBinaryPathName = "BinaryPathName";

    }
}