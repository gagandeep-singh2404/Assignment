/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package appointmentplanner;

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
public class TimeGapTest {

    public TimeGapTest() {
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
    public void testTimeGap() {

        TimeGap timegap = new TimeGap(new Time(10, 30), new Time(12, 00));
        TimeGap timegap2 = new TimeGap(new TimeSpan(01, 30), new Time(10, 30));
        assertEquals(timegap.getLength(), timegap2.getLength());

        // test for end 
        assertEquals(timegap.getEnd(), new Time(12, 00));
        assertEquals(timegap2.getEnd(), new Time(12, 00));
        assertFalse(timegap.getEnd().equals(new Time(11, 10)));

        // test for start 
        assertEquals(timegap.getStart(), timegap2.getStart());
        assertFalse(timegap.getStart().equals(new Time(13, 00)));

        String des = "TimeGap{" + "length=" + timegap.getLength() + ", start=" + timegap.getStart() + ", end=" + timegap.getEnd() + '}';
        assertEquals(des, timegap.toString());
    }

    @Test
    public void equalsTest() {

        TimeGap timegap = new TimeGap(new Time(10, 30), new Time(12, 00));
        TimeGap differentTimeGap = new TimeGap(new TimeSpan(1, 00), new Time(4, 00));
        TimeGap sameTimeGap = new TimeGap(new TimeSpan(1, 30), new Time(10, 30));
        TimeGap sameLength = new TimeGap(new Time(13, 30), new Time(15, 00));
        TimeGap differentEnd = new TimeGap(new Time(10, 30), new Time(13, 00));
        TimeGap differentStart= new TimeGap(new Time(01, 30), new Time(12, 00));
        

        // null
        assertFalse(timegap.equals(null));
        // other class
        assertFalse(timegap.equals(new Time(2, 00)));
        // false start 
        assertFalse(timegap.equals(differentTimeGap.getStart()));
        // false end 
        assertFalse(timegap.equals(differentTimeGap.getEnd()));
        assertFalse(timegap.equals(differentEnd));
        // correct 
        assertTrue(timegap.equals(timegap));
        assertTrue(timegap.equals(sameTimeGap));
        // different lenght and different start and endTimes 
        assertFalse(timegap.equals(sameLength));
        assertFalse(timegap.equals(differentTimeGap));
    }
}
