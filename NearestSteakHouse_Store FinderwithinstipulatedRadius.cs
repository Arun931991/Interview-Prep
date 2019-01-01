int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

public static List<List<int>> nearestXsteakHouses(int totalSteakhouses,
                                               int[,] allLocations,
                                               int numSteakhouses)
        {
            List<List<int>> LocationList = listconversion(allLocations);
            List<List<int>> FinalLocationList = new List<List<int>>();

            Dictionary<List<int>, double> dictionary = new Dictionary<List<int>, double>();



            foreach (var location in LocationList)
            {
                double a =0 ;
                double b = 0;
                foreach (var item in location)
                {
                    a = item * item;//Math.Sqrt(item);
                    b = b + a;

                }
                dictionary.Add(location, Math.Sqrt(b));

            }

            var toplist = dictionary.OrderBy(pair => pair.Value).Take(numSteakhouses);

            FinalLocationList = (from kvp in toplist select kvp.Key).Distinct().ToList();

            //List<string> keyList = new List<string>(sortedDict.Keys);

            Console.WriteLine();
            Console.ReadLine();


            return LocationList;

        }



        public static List<List<int>> listconversion(int[,] _2darray)
        {
            List<List<int>> output = new List<List<int>>();
            for (int i = 0; i < _2darray.GetLength(0); i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < _2darray.GetLength(1); j++)
                {
                    row.Add(_2darray[i, j]);
                }
                output.Add(row);
            }

            return output;
        }
