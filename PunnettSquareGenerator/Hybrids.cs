using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PunnettSquareGenerator
{
    internal class Hybrids
    {
        string firstGenotype, secondGenotype;
        public Hybrids(string f, string s)
        {
            firstGenotype = f;
            secondGenotype = s;
        }
        private int NumberOfGametes(string genotype)
        {
            /*Определяне на броя на гаметите: Ако индивидът е хетерозиготен по даден белег (т.е. има и главна, и малка буква (напр. Аа)),
			броят на възможните гамети се удвоява*/
            int numGam = 1;
            for (int i = 0; i < genotype.Length; i += 2)
            {
                if (genotype[i] != genotype[i + 1])
                {
                    numGam *= 2;
                }
            }
            return numGam;
        }
        private void GetGametes(ref List<string> gametes, string genotype)
        {
            /*Определяне на самите гамети като набор от букви с дължина точно два пъти по-малка от генотипа на родителите.
			Тъй като белезите се унаследяват независимо един от друг, всяка гамета (полова клетка) представлява съвкупност от
			случйно избрани букви от генотипа на родителя, в която присъства по една случайно избрана буква от всеки вид
			(например ако генотипът на родителя е АаВВСс, възможните гамети са АВС, АВс, аВС, аВс)*/
            Random r = new Random();
            string g = "";
            int numOfGam = NumberOfGametes(genotype);
            while (gametes.Count < numOfGam)
            {
                for (int i = 0; i < genotype.Length; i += 2)
                {
                    g += genotype[r.Next(i, i + 2)];
                }
                if (!gametes.Contains(g))
                {
                    gametes.Add(g);
                }
                g = "";
            }
            gametes.Sort();
            gametes.Reverse();
        }
        public string[,] GenerateData()
        {
            int rows = NumberOfGametes(firstGenotype)+1;
            int cols = NumberOfGametes(secondGenotype)+1;
            string[,] punnett = new string[rows,cols];
            punnett[0, 0] = "♀/♂";
            List<string> fgam = new List<string>();
            List<string> sgam = new List<string>();
            GetGametes(ref fgam, firstGenotype);
            GetGametes(ref sgam, secondGenotype);
            /*Записване на гаметите като елементи от първия ред и съответно първата колона на двуизмерния масив.*/
            for (int i = 1; i < rows; i++)
            {
                punnett[i,0] = fgam[i-1];
            }
            for (int i = 1; i < cols; i++)
            {
                punnett[0,i] = sgam[i-1];
            }

            /*Намиране на генотиповете на децата. Всеки от тях се състои от една гамета на единия родител и една гамета на другия родител,
			соритирани по букви (вместо АbСаВС е АаВbСС)*/
            char[] b = new char[2]; //Временно записва буквите от един вид (АА, Аа, аа), за да се сортират първо главна, после малка. След което се нулира.
            string helper; //Временно приема стойността на поредния генотип на детето, за да не става объркване с много индекси.
            List<char> twoAlleles = new List<char>(); /*В него се натрупват поредните две букви от b, вече сортирани главна преди малка.
			След свършване на цикъла twoAlleles съдържа вече напълно сортиран целия пореден генотип на детето, който се записва отново в a[j,i], а twoAlleles се нулира, за да се започне записването на следващия генотип на дете*/
            for (int i = 1; i < punnett.GetLength(0); i++)
            {
                for (int j = 1; j < punnett.GetLength(1); j++)
                {
                   //punnett[j, i] = fgam[i - 1] + sgam[j - 1];
                    helper = (fgam[i - 1] + sgam[j - 1]).ToString();
                    for (int n = 0; n < fgam[0].Length; n++)
                    {
                        b[0] = helper[n];
                        b[1] = helper[n + fgam[0].Length];
                        Array.Sort(b);
                        twoAlleles.AddRange(b);
                    }
                    punnett[i, j] = string.Join("", twoAlleles);
                    helper = "";
                    twoAlleles.Clear();
                }
            }

            return punnett;
        }
        public void ShowPunnettSquare(string[,] arr, DataGridView dg)
        {
            int height = arr.GetLength(0);
            int width = arr.GetLength(1);

            dg.ColumnCount = width;

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dg);

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = arr[r, c];
                }

                dg.Rows.Add(row);
            }
        }
        public List<Frequencies> GenerateFrequencies(DataGridView dg, int relationship, string adData, double total)
        {
            List<Frequencies> flist = new List<Frequencies>();
            Random r = new Random();
            string variant="";
            Frequencies f;
            Color c;
            bool contains = false;
            for (int i = 1; i < dg.RowCount-1; i++)
            {
                for (int j = 1; j < dg.ColumnCount; j++)
                {
                    variant = dg.Rows[i].Cells[j].Value.ToString()+"";
                    switch (relationship)
                    {
                        case 0:
                            break;
                        case 1:
                            variant = FullDominance(variant, adData);
                            break;
                        case 2:
                            variant = IncompleteDominance(variant, adData);
                            break;
                        case 3:
                            variant = Lethal(variant, adData);
                            break;
                        case 4:
                            variant = Complementary(variant, adData);
                            break;
                        case 5:
                            variant = Epistatic(variant, adData);
                            break;
                        case 6:
                            variant = PolygenicCumulative(variant, adData);
                            break;
                        case 7:
                            variant = PolygenicNonCumulative(variant, adData);
                            break;
                        default:
                            break;
                    }
                    foreach (Frequencies fr in flist)
                    {
                        if (fr.Genotype==variant)
                        {
                            fr.number++;
                            dg.Rows[i].Cells[j].Style.BackColor = fr.Color;
                            contains = true;
                            break;
                        }
                    }
                    if(contains==false)
                    {
                        c = Color.FromArgb(r.Next(0, 16) * 16, r.Next(0, 16) * 16, r.Next(0, 16) * 16);
                        f = new Frequencies(variant, 1, 0, c);
                        flist.Add(f);
                        dg.Rows[i].Cells[j].Style.BackColor = c;
                    }
                    contains = false;
                }
            }
            foreach (Frequencies fr in flist)
            {
                fr.percentage = (fr.Number * 100.0)/total;
            }

            return flist;
        }
        private string FullDominance(string variant, string adData)
        {
            return variant;
        }
        private string IncompleteDominance(string variant, string adData)
        {
            return variant;
        }
        private string Lethal(string variant, string adData)
        {
            return variant;
        }
        private string Complementary(string variant, string adData)
        {
            return variant;
        }
        private string Epistatic(string variant, string adData)
        {
            return variant;
        }
        private string PolygenicCumulative(string variant, string adData)
        {
            return variant;
        }
        private string PolygenicNonCumulative(string variant, string adData)
        {
            string gen;
            string[] alleles = adData.Split(',');
            for (int i = 0; i<alleles.Length; i++)
            {
                if (alleles[i].ToLower() == alleles[i])
                    alleles[i] = alleles[i] + "" + alleles[i];
            }
            foreach (string a in alleles)
            {
                if (variant.IndexOf(a)>-1)
                {
                    gen = string.Join('/', alleles);
                    gen += new String('_', variant.Length - alleles.Length);
                    variant = gen;
                    return variant;
                }
            }
            return "NO KEY ALLELES";
        }
        public void ShowFrequencies(List<Frequencies> flist, DataGridView dg)
        {
            dg.ColumnCount = 3;
            dg.Columns[0].HeaderText = "Genotype/Phenotype";
            dg.Columns[1].HeaderText = "Total number";
            dg.Columns[2].HeaderText = "Frequency";
            for (int i = 0; i < flist.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dg);
                row.Cells[0].Value = flist[i].Genotype;
                row.Cells[1].Value = flist[i].Number;
                row.Cells[2].Value = flist[i].Percentage.ToString("f4")+"%";
                row.DefaultCellStyle.BackColor = flist[i].Color;
                dg.Rows.Add(row);
            }
        }
    }
}