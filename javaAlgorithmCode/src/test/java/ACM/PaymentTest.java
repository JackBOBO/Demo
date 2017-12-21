package ACM;

import org.junit.Test;

import static org.junit.Assert.*;

/**
 * Created by chenlong on 2017/5/26.
 */
public class PaymentTest {
    @Test
    public void solve() throws Exception {
        int[] c = {3, 2, 1, 3, 0, 2};

        int res = Payment.solve(620, c);

        assertEquals("Payment", 6, res);
    }


}