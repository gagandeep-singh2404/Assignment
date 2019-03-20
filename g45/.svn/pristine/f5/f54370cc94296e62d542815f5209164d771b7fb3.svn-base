/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package appointmentplanner;

import appointmentplanner.util.Priority;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author gagandeepsingh
 */
public class PriorityTest {

    public PriorityTest() {
    }

    @BeforeClass
    public static void setUpClass() {
    }

    @AfterClass
    public static void tearDownClass() {
    }

    @Before
    public void setUp() {
    }

    @After
    public void tearDown() {
    }

    // TODO add test methods here.
    // The methods must be annotated with annotation @Test. For example:
    //
    // @Test
    // public void hello() {}
    @Test
    public void setPriorityTest() {

        Priority pr = Priority.HIGH;

        pr.setPriority(0);

        assertEquals(Priority.LOW.getPriority(), pr.getPriority());

    }

    @Test
    public void testPriorityString() {
        for (Priority value : Priority.values()) {
            assertEquals(Priority.valueOf(value.toString()), value);
        }
    }
}
