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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataPipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataPipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TaskObject Object
    /// </summary>  
    public class TaskObjectUnmarshaller : IUnmarshaller<TaskObject, XmlUnmarshallerContext>, IUnmarshaller<TaskObject, JsonUnmarshallerContext>
    {
        TaskObject IUnmarshaller<TaskObject, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public TaskObject Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TaskObject unmarshalledObject = new TaskObject();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("attemptId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AttemptId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("objects", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, PipelineObject, StringUnmarshaller, PipelineObjectUnmarshaller>(StringUnmarshaller.Instance, PipelineObjectUnmarshaller.Instance);
                    unmarshalledObject.Objects = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pipelineId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PipelineId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TaskObjectUnmarshaller _instance = new TaskObjectUnmarshaller();        

        public static TaskObjectUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}