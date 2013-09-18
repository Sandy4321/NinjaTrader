﻿using AlsiUtils;
using AlsiUtils.Data_Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace AlgoSecondLayer
{
    public class Utils
    {
        public static void PrintAllProperties(object obj)
        {
            Console.WriteLine("===========Print new object====================");
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(obj);
                Console.WriteLine("{0}={1}", name, value);
            }
            Console.WriteLine("===============================================");
        }

        public static void Fix()
        {

            string SIMcontext = @"Data Source=85.214.244.19;Initial Catalog=ALSI_SIM;User ID=SimLogin;Password=boeboe;MultipleActiveResultSets=True";
            var dc = new AlsiSimDataContext(SIMcontext);

            foreach (var v in dc.tblResult_5Min_SSPOPs)
            {
                var c = v.Sequence.IndexOf(',');
                var x = v.Sequence.Substring(c + 1);
                var q = new tblResult_5Min_SSPOP()
                {
                    Notes = "New",
                    Sequence = x,
                    Profit = v.Profit,

                };
                try
                {
                    dc.tblResult_5Min_SSPOPs.InsertOnSubmit(q);
                    dc.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Skipping " + q.Sequence);
                }
            }
        }

        public static void CountPermutations()
        {
            List<string> Seq = new List<string>();


            for (int fastK = 3; fastK < 30; fastK++)
                for (int slowK = 3; slowK < 30; slowK++)
                    for (int slowD = 3; slowD < 30; slowD++)
                        for (int u_75 = 65; u_75 < 85; u_75++)
                            for (int l_25 = 15; l_25 < 45; l_25++)
                                for (int lim_high = 70; lim_high < 95; lim_high++)
                                    for (int lim_low = 5; lim_low < 30; lim_low++)
                                        for (int stoploss = 20; stoploss < 200; stoploss+=10)
                                            for (int profit = 20; profit < 200; profit+=10)
                                            {
                                                if (lim_high > u_75 && lim_low < l_25)
                                                {
                                                    StringBuilder s = new StringBuilder();
                                                    s.Append(fastK + "," + slowK + "," + slowD + "," + u_75 + "," + l_25 + "," + lim_high + "," + lim_low + "," + stoploss + "," + profit);
                                                    if (fastK != slowK)
                                                        Seq.Add(s.ToString());
                                                }
                                            }

            string SIMcontext = @"Data Source=85.214.244.19;Initial Catalog=ALSI_SIM;User ID=SimLogin;Password=boeboe;MultipleActiveResultSets=True";
            var dc = new AlsiSimDataContext(SIMcontext);

            DataTable MinData = new DataTable("tblSequence");
            MinData.Columns.Add("Sequence", typeof(string));
            MinData.Columns.Add("Started", typeof(bool));
            MinData.Columns.Add("Completed", typeof(bool));
            foreach (var t in Seq)
            {
                MinData.Rows.Add(t, false, false);
                Debug.WriteLine("Adding {0}", t);
            }

            DataSet DataSet = new DataSet("Dataset");
            DataSet.Tables.Add(MinData);
            SqlConnection myConnection = new SqlConnection(SIMcontext);
            myConnection.Open();
            SqlBulkCopy bulkcopy = new SqlBulkCopy(myConnection);
            bulkcopy.BulkCopyTimeout = 500000;
            bulkcopy.DestinationTableName = "tblSequence";
            bulkcopy.WriteToServer(MinData);
            MinData.Dispose();
            myConnection.Close();
        }

        public static void PrintTrades()
        {
            var sr = new StreamReader(@"D:\ohlcPL.csv");

        }


        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }
    }
}
