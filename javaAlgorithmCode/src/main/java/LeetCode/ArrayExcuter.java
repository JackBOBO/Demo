package LeetCode;

/**
 * Created by chenlong on 14/01/2018.
 */
public class ArrayExcuter {

    /*
    *
    */
    public static int RemoveElement(int A[], int n,int elem) {
        int j=0;

        for (int i=0;i<n;i++)
        {
            if (A[i] == elem)
            {
                continue;
            }

            A[j] = A[i];
            j++;
        }

        return j;
    }

    public static int RemoveDuplicates(int A[],int n)
    {
        if (n == 0){
            return  0;
        }

        int j = 0;
        for (int i = 1;i<n;i++){
            if (A[j] != A[i])
            {
                A[++j] = A[i];
            }
        }

        return j+1;
    }
}
