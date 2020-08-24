using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Controls;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.Win32;
using System.Data;

namespace RE2_ItemTracker
{
    class ButtonTracker
    {
        public bool[,] CheckBtn = new bool[7, 7];
       // public static bool[] CheckSce = new bool[4] { false, false, false, false };

        public int ColumnCount { get; set; }
        public int RowCount { get; set; }

        public ButtonTracker()
        {
            for (int i = 0; i < CheckBtn.GetLength(0); i++)
            {
                for (int j = 0; j < CheckBtn.GetLength(1); j++)
                {
                    CheckBtn[i, j] = false;
                }
            }
        }

        public void SetColumnRowCount(Grid aGrid)
        {
            ColumnCount = aGrid.ColumnDefinitions.Count;
            RowCount = aGrid.RowDefinitions.Count;
        }

        public void SetChecked(int aRow, int aColumn)
        {
            CheckBtn[aRow, aColumn] = true;
        }

        public void SetUnchecked(int aRow, int aColumn)
        {
            CheckBtn[aRow, aColumn] = false;
        }

        public bool GetChecked(int aRow, int aColumn)
        {
            return CheckBtn[aRow, aColumn];
        }

        public void SaveState(object t)
        { 
            SaveFileDialog saveProg = new SaveFileDialog();
            saveProg.Filter = "RE2 ItemTracker Save File (*.re2it)|*.re2it";
            if (saveProg.ShowDialog() == true)
            {
                Stream stream = File.Open(saveProg.FileName, FileMode.Create);
                BinaryFormatter bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, t);
                stream.Close();
            } 
        }

        public bool[,] LoadState()
        {
            OpenFileDialog openProg = new OpenFileDialog();
            openProg.Filter = "Re2 ItemTracker Save File (*.re2it)|*.re2it";

            if (openProg.ShowDialog() == true)
            {
                Stream stream = File.Open(openProg.FileName, FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();
                CheckBtn = (bool[,])bformatter.Deserialize(stream);
            }

            return CheckBtn;
        }
    }
}













/* public bool[,] InitArray(int aRow, int aColumn)
  {
      var l_Array = new bool[aRow, aColumn];
      RowCount = aRow;
      ColumnCount = aColumn;

      for(int i = 0; i < l_Array.GetLength(0); i++)
      {
          for (int j = 0; j < l_Array.GetLength(1); j++)
          {
              l_Array[i, j] = false;
          }
      }

  } */


/* public void SetColumnRowCount(Grid aGrid)
        {
            ColumnCount = aGrid.ColumnDefinitions.Count;
            RowCount = aGrid.RowDefinitions.Count;
        } */
