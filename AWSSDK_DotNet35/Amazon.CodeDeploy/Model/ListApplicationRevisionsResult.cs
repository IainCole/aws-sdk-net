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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Represents the output of a list application revisions operation.
    /// </summary>
    public partial class ListApplicationRevisionsResult : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RevisionLocation> _revisions = new List<RevisionLocation>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the amount of information that is returned is significantly large, an identifier
        /// will also be returned, which can be used in a subsequent list application revisions
        /// call to return the next set of application revisions in the list.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Revisions. 
        /// <para>
        /// A list of revision locations that contain the matching revisions.
        /// </para>
        /// </summary>
        public List<RevisionLocation> Revisions
        {
            get { return this._revisions; }
            set { this._revisions = value; }
        }

        // Check to see if Revisions property is set
        internal bool IsSetRevisions()
        {
            return this._revisions != null && this._revisions.Count > 0; 
        }

    }
}