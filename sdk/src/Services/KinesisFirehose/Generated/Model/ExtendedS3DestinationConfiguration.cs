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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes the configuration of a destination in Amazon S3.
    /// </summary>
    public partial class ExtendedS3DestinationConfiguration
    {
        private string _bucketARN;
        private BufferingHints _bufferingHints;
        private CloudWatchLoggingOptions _cloudWatchLoggingOptions;
        private CompressionFormat _compressionFormat;
        private EncryptionConfiguration _encryptionConfiguration;
        private string _prefix;
        private ProcessingConfiguration _processingConfiguration;
        private string _roleARN;
        private S3DestinationConfiguration _s3BackupConfiguration;
        private S3BackupMode _s3BackupMode;

        /// <summary>
        /// Gets and sets the property BucketARN. 
        /// <para>
        /// The ARN of the S3 bucket.
        /// </para>
        /// </summary>
        public string BucketARN
        {
            get { return this._bucketARN; }
            set { this._bucketARN = value; }
        }

        // Check to see if BucketARN property is set
        internal bool IsSetBucketARN()
        {
            return this._bucketARN != null;
        }

        /// <summary>
        /// Gets and sets the property BufferingHints. 
        /// <para>
        /// The buffering option.
        /// </para>
        /// </summary>
        public BufferingHints BufferingHints
        {
            get { return this._bufferingHints; }
            set { this._bufferingHints = value; }
        }

        // Check to see if BufferingHints property is set
        internal bool IsSetBufferingHints()
        {
            return this._bufferingHints != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions. 
        /// <para>
        /// The CloudWatch logging options for your delivery stream.
        /// </para>
        /// </summary>
        public CloudWatchLoggingOptions CloudWatchLoggingOptions
        {
            get { return this._cloudWatchLoggingOptions; }
            set { this._cloudWatchLoggingOptions = value; }
        }

        // Check to see if CloudWatchLoggingOptions property is set
        internal bool IsSetCloudWatchLoggingOptions()
        {
            return this._cloudWatchLoggingOptions != null;
        }

        /// <summary>
        /// Gets and sets the property CompressionFormat. 
        /// <para>
        /// The compression format. If no value is specified, the default is UNCOMPRESSED.
        /// </para>
        /// </summary>
        public CompressionFormat CompressionFormat
        {
            get { return this._compressionFormat; }
            set { this._compressionFormat = value; }
        }

        // Check to see if CompressionFormat property is set
        internal bool IsSetCompressionFormat()
        {
            return this._compressionFormat != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration. If no value is specified, the default is no encryption.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered S3 files.
        /// You can specify an extra prefix to be added in front of the time format prefix. Note
        /// that if the prefix ends with a slash, it appears as a folder in the S3 bucket. For
        /// more information, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/basic-deliver.html">Amazon
        /// S3 Object Name Format</a> in the <i>Amazon Kinesis Firehose Developer Guide</i>.
        /// </para>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingConfiguration. 
        /// <para>
        /// The data processing configuration.
        /// </para>
        /// </summary>
        public ProcessingConfiguration ProcessingConfiguration
        {
            get { return this._processingConfiguration; }
            set { this._processingConfiguration = value; }
        }

        // Check to see if ProcessingConfiguration property is set
        internal bool IsSetProcessingConfiguration()
        {
            return this._processingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The ARN of the AWS credentials.
        /// </para>
        /// </summary>
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property S3BackupConfiguration. 
        /// <para>
        /// The configuration for backup in Amazon S3.
        /// </para>
        /// </summary>
        public S3DestinationConfiguration S3BackupConfiguration
        {
            get { return this._s3BackupConfiguration; }
            set { this._s3BackupConfiguration = value; }
        }

        // Check to see if S3BackupConfiguration property is set
        internal bool IsSetS3BackupConfiguration()
        {
            return this._s3BackupConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3BackupMode. 
        /// <para>
        /// The Amazon S3 backup mode.
        /// </para>
        /// </summary>
        public S3BackupMode S3BackupMode
        {
            get { return this._s3BackupMode; }
            set { this._s3BackupMode = value; }
        }

        // Check to see if S3BackupMode property is set
        internal bool IsSetS3BackupMode()
        {
            return this._s3BackupMode != null;
        }

    }
}