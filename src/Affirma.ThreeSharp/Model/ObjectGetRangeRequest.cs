/******************************************************************************* 
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://www.apache.org/licenses/LICENSE-2.0.html 
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 * 
 *  Joel Wetzel
 *  Affirma Consulting
 *  jwetzel@affirmaconsulting.com
 * 
*  Joel Hewitt
 *  09.06.2008 added/modified for range request
 * 
 */

using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Affirma.ThreeSharp.Model
{
    public class ObjectGetRangeRequest : Request
    {
        public ObjectGetRangeRequest(String bucketName, String key, int RangeFrom, int RangeTo)
        {
            this.Method = "GET";

            this.BucketName = bucketName;
            this.Key = key;
			//this.ExtraData.Add("Range:",RangeFrom.ToString()+"-"+RangeTo.ToString());
        }
    }
}
