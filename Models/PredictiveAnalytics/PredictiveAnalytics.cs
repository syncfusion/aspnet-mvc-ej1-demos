#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.JavaScript;
using Syncfusion.PMML;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSampleBrowser.Models
{
    public class DataResult
    {
        public IEnumerable result { get; set; }
        public int count { get; set; }
    }
    public class Sample
    {
        public string Name { get; set; }

        public string SamplePath { get; set; }

        public string ModelName { get; set; }

        public int SkipCount { get; set; }

        public Table InputTable { get; set; }

        public Table OutputTable { get; set; }

        private int takeCount = 0;

        /// <summary>
        /// Serialize the values in a list
        /// </summary>
        /// <param name="inputTable">input table values</param>
        /// <param name="outputTable">output table values</param>
        public List<Dictionary<string, object>> serializeTable(Table inputTable, Table outputTable, int skipCount)
        {
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();

            int outputCount = 0;

            for (int i = 0; i < inputTable.RowCount; i++)
            {
                Dictionary<string, object> row = new Dictionary<string, object>();

                for (int j = 0; j < inputTable.ColumnCount; j++)
                {
                    row[inputTable.ColumnNames[j]] = inputTable[i, j];
                }

                if (i >= skipCount && i < skipCount + takeCount)
                {
                    for (int j = 0; j < outputTable.ColumnCount; j++)
                    {
                        row[outputTable.ColumnNames[j]] = outputTable[outputCount, j];
                    }
                    outputCount++;
                }
                //Add dictionary row to rows list
                rows.Add(row);
            }

            return rows;
        }

        /// <summary>
        /// Apply Paging to filter inputs 
        /// </summary>
        /// <param name="inputTable">Input Table</param>
        /// <returns>Selected Page Inputs</returns>
        public Syncfusion.PMML.Table PagingMethod(Table inputTable, DataManager dataManager, int skipCount)
        {
            takeCount = dataManager == null ? 1 : dataManager.Take + dataManager.Skip > inputTable.RowCount ?
                inputTable.RowCount - dataManager.Skip : dataManager.Take;

            Table pageInputs = new Table(takeCount, inputTable.ColumnCount);

            for (int k = 0; k < inputTable.ColumnCount; k++)
            {
                pageInputs.ColumnNames[k] = inputTable.ColumnNames[k].ToString();
            }

            int testCount = 0;

            for (int i = 0; i < inputTable.RowCount; i++)
            {
                if (i >= skipCount && i < skipCount + takeCount)
                {
                    for (int j = 0; j < pageInputs.ColumnCount; j++)
                    {
                        pageInputs[testCount, j] = inputTable[i, j];
                    }
                    testCount++;
                }
            }

            return pageInputs;
        }

        /// <summary>
        /// Gets the parent directory path
        /// </summary>
        /// <param name="path">server path</param>
        /// <returns>Parent directory path</returns>
        public string GetParentDirectoryPath(string path)
        {
            DirectoryInfo info = new DirectoryInfo(path);
            for (int i = 0; i < 4; i++)
            {
                DirectoryInfo test = new DirectoryInfo(info.FullName + "/App_Data/PredictiveAnalytics");
                if (test.Exists)
                    break;
                info = info.Parent;
            }

            return info.FullName + "/App_Data/PredictiveAnalytics";
        }

        /// <summary>
        /// Gets the column names 
        /// </summary>
        /// <param name="inputTable">input table</param>
        /// <param name="outputTable">output table</param>
        /// <returns>column names collection</returns>
        public Dictionary<string, List<string>> GetColumnNames(Table inputTable, Table outputTable)
        {
            double result = 0d;
            List<string> inputNumericColumns = new List<string>();
            List<string> outputNumericColumns = new List<string>();
            Dictionary<string, List<string>> columnCollection = new Dictionary<string, List<string>>();

            //Input columns list
            List<string> inputColumnsList = inputTable.ColumnNames.ToList();
            //Output columns list
            List<string> outputColumnsList = outputTable.ColumnNames.ToList(); 

            //Input columns list with numeric values
            for (int i = 0; i < inputTable.ColumnCount; i++)
            {
                var cellvalue = inputTable[0, i].ToString();
                if (double.TryParse(cellvalue, out result))
                {
                    inputNumericColumns.Add(inputTable.ColumnNames[i]);
                }
            }
            //Output columns list with numeric values
            for (int i = 0; i < outputTable.ColumnCount; i++)
            {
                var cellvalue = outputTable[0, i].ToString();
                if (double.TryParse(cellvalue, out result))
                {
                    outputNumericColumns.Add(outputTable.ColumnNames[i]);
                }
            }

            columnCollection.Add("inputColumns", inputColumnsList);
            columnCollection.Add("outputColumns", outputColumnsList);
            columnCollection.Add("inputNumericColumns", inputNumericColumns);
            columnCollection.Add("outputNumericColumns", outputNumericColumns);

            return columnCollection;
        }
    }
}
