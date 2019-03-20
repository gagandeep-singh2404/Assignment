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
public class TimeSpanTest {

    public TimeSpanTest() {
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

    @Test
    public void SimpleConstructorTest() {

        TimeSpan ts = new TimeSpan(01, 11);
        Time time = new Time(01, 11);
        TimeSpan newTs = new TimeSpan(new Time(10,00),new Time(11, 11)); 
        
        assertEquals(time.getHours(), ts.getHours());
        assertEquals(time.getMinutes(), ts.getMinutes());
        // With time
        assertEquals(time.getHours(), newTs.getHours());
        assertEquals(time.getMinutes(), newTs.getMinutes());
        assertTrue(newTs.equals(ts));
       
        ts = new TimeSpan(new Time(10,00), new Time(9,00)); 
        time = new Time(1, 0); 
        assertEquals(time.getHours(), ts.getHours());
        assertEquals(time.getMinutes(), ts.getMinutes());
        assertEquals(60, ts.getTimeSpanInMinutes());
    }

    

    @Test
    public void addTimeToTimeSpanTest() {

        TimeSpan ts = new TimeSpan(3, 22);
        TimeSpan expected = new TimeSpan(10, 00);
        ts.addTimeSpan(new TimeSpan(6, 38));
        assertEquals(expected, ts);

    }

    @Test
    public void TimeInMinutesTest() {

        int firstMinute = 300;
        int secondMinute = 250;
        int thirdMinute = 30;

        TimeSpan ts1 = new TimeSpan(5, 00);
        TimeSpan ts2 = new TimeSpan(4, 10);
        TimeSpan ts3 = new TimeSpan(0, 30);

        assertEquals(firstMinute, ts1.getTimeSpanInMinutes());
        assertEquals(secondMinute, ts2.getTimeSpanInMinutes());
        assertEquals(thirdMinute, ts3.getTimeSpanInMinutes());
    }

    @Test
    public void isSmallerThanTest() {

        TimeSpan ts1 = new TimeSpan(5, 00);
        TimeSpan ts2 = new TimeSpan(4, 10);
        TimeSpan ts3 = new TimeSpan(0, 30);

        assertTrue(ts2.isSmallerThan(ts1));
        assertFalse(ts1.isSmallerThan(ts3));
    }

    @Test
    public void staticTimeSpanTest() {
        Time ts2 = new Time(2, 25);
        Time ts3 = new Time(3, 40);
        assertEquals(75, TimeSpan.getMinutesInTimeSpan(ts2, ts3));
        
        System.out.println(TimeSpan.getMinutesInTimeSpan(ts2, ts3));
    }

    @Test
    public void hashCodeTest(){
        TimeSpan first = new TimeSpan(1, 00); 
        TimeSpan firstInTime = new TimeSpan(new Time(9,00), new Time(10, 00)); 
        TimeSpan second = new TimeSpan(3,30); 
        TimeSpan secondInTime = new TimeSpan(new Time(10,00),new Time(13, 30)); 
        
        
        
        int firstResult = first.hashCode(); 
        int secondresult = second.hashCode(); 
        
        
        assertEquals(firstResult,firstInTime.hashCode());
        assertFalse(firstResult == second.hashCode());
        assertFalse(firstResult == secondInTime.hashCode());
        
        assertTrue(secondresult == secondInTime.hashCode());
 
    }
    
    
    @Test 
    public void toStringTest(){
        
        TimeSpan first = new TimeSpan(2, 00); 
        
        assertEquals("TimeSpan{" + "span=02:00" + '}', first.toString());
        
    }
    
    
    
    @Test 
    public void equalsTest(){
        TimeSpan ts = new TimeSpan(new Time(1, 00),new Time(2,00)); 
        TimeSpan span = new TimeSpan(1,00);
        
        assertTrue(ts.equals(span));
        assertFalse(ts.equals(new TimeSpan(3, 00)));
        assertFalse(ts.equals(new Time(1, 00)));
        assertFalse(ts.equals(null));

        
    }
}
