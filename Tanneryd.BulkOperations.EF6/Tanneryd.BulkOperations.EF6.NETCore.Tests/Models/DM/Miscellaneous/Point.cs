﻿/*
* Copyright ©  2017-2019 Tånneryd IT AB
* 
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
* 
*   http://www.apache.org/licenses/LICENSE-2.0
* 
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/
namespace Tanneryd.BulkOperations.EF6.NETCore.Tests.Models.DM.Miscellaneous
{
    public class Point
    {
        public int XCoordinateId { get; set; }
        public Coordinate XCoordinate { get; set; }
        public int YCoordinateId { get; set; }
        public Coordinate YCoordinate { get; set; }

        public double Value { get; set; }

    }
}