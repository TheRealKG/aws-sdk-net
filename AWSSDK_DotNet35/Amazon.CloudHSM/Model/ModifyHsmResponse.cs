/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */

using System;

namespace Amazon.CloudHSM.Model
{
    /// <summary>
    /// Configuration for accessing Amazon ModifyHsm service
    /// </summary>
    public partial class ModifyHsmResponse : ModifyHsmResult
    {
        /// <summary>
        /// Gets and sets the ModifyHsmResult property.
        /// Represents the output of a ModifyHsm operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the ModifyHsmResult class are now available on the ModifyHsmResponse class. You should use the properties on ModifyHsmResponse instead of accessing them through ModifyHsmResult.")]
        public ModifyHsmResult ModifyHsmResult
        {
            get
            {
                return this;
            }
        }
    }
}