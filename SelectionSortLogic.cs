for(int i=0; i<list.Count; i++)
        {
          int temp;  
          for(int j=i+1; j<list.Count; j++)
          {
            if(list[i]>list[j])
            {
              temp=list[i];
              list[i]=list[j];
              list[j]=temp;
            }
              
          }
        }
