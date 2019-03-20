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
public class AppointmentTest {

    public AppointmentTest() {
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
    public void setStartTime() {
        Appointment app = new Appointment("Lunchbreak", new TimeSpan(0, 30));
        Time start = new Time(3, 00);
        Time end = new Time(3, 30);
        app.setStart(start);
        assertEquals(start, app.getStart());
        assertEquals(end, app.getEnd());

    }

    @Test
    public void getEndTest() {
        Appointment app = new Appointment("Lunchbreak", new TimeSpan(0, 30));
        assertEquals(null, app.getEnd());
    }

    @Test
    public void getPriorityTest() {
        String describtion = "Tests";
        Appointment app = new Appointment(describtion, new TimeSpan(1, 40), Priority.HIGH);

        assertEquals(Priority.HIGH, app.getPriority());
        app.setPriority(Priority.LOW);
        assertEquals(Priority.LOW, app.getPriority());
        app.setPriority(Priority.MEDIUM);
        assertEquals(Priority.MEDIUM, app.getPriority());
    }

    @Test
    public void compareTest() {
        String describtion = "Tests";
        Appointment app = new Appointment(describtion, new TimeSpan(1, 40), Priority.HIGH);
        Appointment differentApp = new Appointment(describtion,new TimeSpan(3, 30), Priority.LOW); 
        
        assertEquals(1, app.compareTo(differentApp));
        differentApp.setPriority(Priority.HIGH);
        assertEquals(0, app.compareTo(differentApp));
        app.setPriority(Priority.LOW);
        assertEquals(-1, app.compareTo(differentApp));
        
    }
}
