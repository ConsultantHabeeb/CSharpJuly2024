

//Test the integer array
TestArray();

//Test the string array
TestStringArray();




public static void TestStringArray()
        {
            string [] days = new string [] {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday"};

            foreach(string x in days)
            {
                Console.WriteLine(x);
            }
       
        }

        public static void TestArray()
        {
            int [] marks = new int[6];
            marks[0] = 50;
            marks[1] = 30;//Failed
            marks[2] = 70;
            marks[3] = 17;
            marks[4] = 90;
            marks[5] = 76;
           // marks[6] = 89;
           //Number of passed candidates: 5
           //Number of failed candidates: 1
          
          int passedcandidates = 0, failedcandidates=0;

            /*
                foreach(mark in marks) //for collections
                {
                 if(mark >=35)

                }
            */
          for(int i=0; i<marks.Length; i++)
           {
             
             if (marks[i]>=35)
             {
                    passedcandidates++; //passedcandidates = passedcandidates +1;
             }
             else
             {
                failedcandidates += 1;
            
             }
           }
            Console.WriteLine("Number of passed candidates:" + passedcandidates);
            Console.WriteLine("Number of failed candidates:" + failedcandidates);
        }
