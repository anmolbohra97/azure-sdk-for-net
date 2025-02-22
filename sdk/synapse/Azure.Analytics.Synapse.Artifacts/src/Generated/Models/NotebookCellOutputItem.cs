// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> An item of the notebook cell execution output. </summary>
    public partial class NotebookCellOutputItem
    {
        /// <summary> Initializes a new instance of NotebookCellOutputItem. </summary>
        /// <param name="outputType"> Execution, display, or stream outputs. </param>
        public NotebookCellOutputItem(CellOutputType outputType)
        {
            OutputType = outputType;
        }

        /// <summary> Initializes a new instance of NotebookCellOutputItem. </summary>
        /// <param name="name"> For output_type=stream, determines the name of stream (stdout / stderr). </param>
        /// <param name="executionCount"> Execution sequence number. </param>
        /// <param name="outputType"> Execution, display, or stream outputs. </param>
        /// <param name="text"> For output_type=stream, the stream's text output, represented as a string or an array of strings. </param>
        /// <param name="data"> Output data. Use MIME type as key, and content as value. </param>
        /// <param name="metadata"> Metadata for the output item. </param>
        internal NotebookCellOutputItem(string name, int? executionCount, CellOutputType outputType, object text, object data, object metadata)
        {
            Name = name;
            ExecutionCount = executionCount;
            OutputType = outputType;
            Text = text;
            Data = data;
            Metadata = metadata;
        }

        /// <summary> For output_type=stream, determines the name of stream (stdout / stderr). </summary>
        public string Name { get; set; }
        /// <summary> Execution sequence number. </summary>
        public int? ExecutionCount { get; set; }
        /// <summary> Execution, display, or stream outputs. </summary>
        public CellOutputType OutputType { get; set; }
        /// <summary> For output_type=stream, the stream's text output, represented as a string or an array of strings. </summary>
        public object Text { get; set; }
        /// <summary> Output data. Use MIME type as key, and content as value. </summary>
        public object Data { get; set; }
        /// <summary> Metadata for the output item. </summary>
        public object Metadata { get; set; }
    }
}
