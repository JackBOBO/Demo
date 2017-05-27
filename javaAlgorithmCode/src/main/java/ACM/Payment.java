package ACM;

/**
 * Created by chenlong on 2017/5/26.
 */
public class Payment {
    public static final int[] V = {1, 5, 10, 50, 100, 500};


    public static int solve(int total,int[] C) {
        int ans = 0;

        for (int i = 5; i >= 0; i--) {

            int t = Math.min(total / V[i], C[i]);
            total -= t * V[i];
            ans += t;
        }

        return ans;
    }
}
