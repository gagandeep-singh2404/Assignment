package appointmentplanner;

//TODO
import appointmentplanner.util.Priority;
import appointmentplanner.util.Queue;
import appointmentplanner.util.Stack;
import java.util.Arrays;

/**
 *
 * @author gagandeepsingh
 */
public final class Day {

    public final static String[] DAYS = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
    public final static Time DAY_START = new Time(8, 30);
    public final static Time DAY_END = new Time(17, 30);
    public final static Time LUNCH_TIME = new Time(12, 30);
    public final static TimeSpan DAY_PART = new TimeSpan(4, 0);
    public final static Appointment LUNCH_BREAK = new Appointment("lunch break", new TimeSpan(1, 0));
    public final static TimeSpan StartAndEnd = new TimeSpan(0, 0);
    public final static String START_DESCRIPTION = "Start of the Day";
    public final static Appointment START_OF_DAY = new Appointment(START_DESCRIPTION, StartAndEnd, Priority.NOTOUCH);
    public final static String END_DESCRIPTION = "End of the Day";
    public final static Appointment END_OF_DAY = new Appointment(END_DESCRIPTION, StartAndEnd, Priority.NOTOUCH);

    private final static Time AFTERNOON_START = new Time(13, 30);
    private Node<Appointment> appointments = null;
    private final int nr;

    /**
     * The number of appointments added by the user.
     */
    private int nrOfAppointments;

    private static class Node<E> {

        //TODO: implement a linked list inner class.
        private Node<E> next;
        private E item;

        public Node(E item) {
            // head
            this.item = item;
            this.next = null;
        }

//        public Node(E item, Node<E> next) {
//            this.item = item;
//            this.next = next;
//        }

//        int sizeOfDummyHeadList(Node<E> list) {
//            //TODO: implement a linked list with a dummy head.
//            Node<E> newList = list;
//            int counter = 1;
//
//            while (newList != null) {
//                counter++;
//                newList = newList.next;
//            }
//
//            return counter;
//        }
    }

    /**
     * Creates a Day object with no appointments. A week does not contain a
     * weekend: no appointments on Saturdays or Sundays. Days of the week are
     * numbered as follows: Monday = 1 .. Friday = 5.
     *
     * @param nr day of the week: Monday = 1 .. Sunday = 7.
     */
    public Day(int nr) {
        this.nr = nr;
        LUNCH_BREAK.setStart(LUNCH_TIME);
        this.nrOfAppointments = 0;
        //TODO initialize datastructure for the appointments.

        if (nr >= 1 && nr <= 5) {

            END_OF_DAY.setStart(DAY_END);
            Node<Appointment> dayEnd = new Node<>(END_OF_DAY);
            START_OF_DAY.setStart(DAY_START);
            Node<Appointment> dayStart = new Node<>(START_OF_DAY);

            this.appointments = new Node<>(null);

            LUNCH_BREAK.setStart(LUNCH_TIME);
            this.appointments.next = new Node<>(LUNCH_BREAK);
            this.appointments.next = dayStart;
            this.appointments.next.next = new Node<>(LUNCH_BREAK);
            this.appointments.next.next.next = dayEnd;
            this.nrOfAppointments++;
        }
    }

    /**
     * Returns the number of appointments on this day, including the lunch break
     * which is always present.
     *
     * @return Number of appointments on this day!
     */
    public int getNrOfAppointments() {
        return this.nrOfAppointments;
    }

    // METHODS INTRODUCED IN WEEK 3 OF APPOINTMENT PROJECT
    /**
     * Returns the name of the day in English. So if number of this day is 1,
     * the return value is "Monday" etc.
     *
     * @return String holding name of this day.
     */
    public String getNameOfTheDay() {
        return DAYS[nr - 1];
    }

    /**
     * Checks if an appointment of given duration can be made. Returns true if
     * an appointment can be made, false otherwise.
     *
     * @param duration time length of appointment
     * @return true if there is a gap of at least the size of duration in the
     * planning.
     */
    public boolean canAddAppointmentOfDuration(TimeSpan duration) {

        TimeGap[] timegaps = this.getAvailableTimeGaps();

        for (TimeGap timegap : timegaps) {

            if (duration.getTimeSpanInMinutes() <= timegap.getLength().getTimeSpanInMinutes()) {
                return true;
            }
        }
        return false;
    }

    /**
     * Adds a new appointment to this day. The description of the appointment
     * should be unique for this day. Objective is to insert an appointment in
     * such a way that the list keeps all of its appointments ordered in time.
     * <pre>
     * pre:  The start time of the appointment has been set.<br>
     *       The start time lies outside the time spans of other appointments.
     *       The appointment does not overlap with existing appointments on this day.
     * post: The appointment has been added to this day.
     * </pre> In case the pre-conditions are not fulfilled, the appointment will
     * not be added to this day.
     *
     * @param appointment start time of the appointment has been set in advance
     */
    public void addAppointmentWithStartTimeSet(Appointment appointment) {
        //TODO
        Time[] allStartTimes = this.getAvailableStartTimesForAppointmentsOfDuration(appointment.getDuration());
        Node<Appointment> appointmentNode = new Node(appointment);
        Node<Appointment> nodeList = appointments;

        // check if incoming appoinment is valid 
        if (!isValid(appointment))return;

        Time endTime = DAY_START;

        while (nodeList.next != null) {

            Appointment nextAppointment = nodeList.next.item;

            // check if appointment is in proper area and is not over other appointments 
            if ((endTime.isBefore(appointment.getStart())
                    || appointment.getStart().equals(endTime)) && (appointment.getEnd().isBefore(nextAppointment.getStart())
                    || appointment.getEnd().equals(nextAppointment.getStart()))) {

                Node<Appointment> tempNode = nodeList.next;
                // currentNode.next is the new Node
                nodeList.next = appointmentNode;
                // new appointment gets old Next
                appointmentNode.next = tempNode;

                this.nrOfAppointments++;
                return;
            }

            nodeList = nodeList.next;
            endTime = nodeList.item.getEnd();
        }
    }

    private boolean isValid(Appointment appointment) {

        if (appointment.getStart() == null) return false;
        if (appointment.getStart().isBefore(DAY_START) || DAY_END.isBefore(appointment.getEnd())) return false;
        if (this.containsAppointmentWithDescription(appointment.getDescription())) return false;
        if (!this.canAddAppointmentOfDuration(appointment.getDuration())) return false;

        return true;
    }

    /**
     * Adds a new appointment to this day. The method searches a time gap for an
     * appointment of given duration. This will be done according to the first
     * fit approach. The description of the appointment should be unique for
     * this day. The start time will be set by this method, and the appointment
     * is added to this day. The result is that the list of appointments in this
     * class is ordered in time.
     *
     * @param appointment The appointment that will be added to this day.
     */
    public void addAppointment(Appointment appointment) {
        //TODO

        if (this.canAddAppointmentOfDuration(appointment.getDuration())) {
            Time[] startTimes = new Time[nrOfAppointments];
            startTimes = this.getAvailableStartTimesForAppointmentsOfDuration(appointment.getDuration());

            appointment.setStart(startTimes[0]);
            this.addAppointmentWithStartTimeSet(appointment);
        }

    }

    /**
     * Removes the appointment with the given description.
     *
     * @param description The description of the appointment for which a search
     * has to be done.
     */
    public void removeAppointment(String description) {
        //TODO

        Node<Appointment> nextNode = appointments.next;

        while (nextNode.next != null) {

            if (nextNode.next.item.getDescription().endsWith(description)) {

                nextNode.next = nextNode.next.next;
                this.nrOfAppointments--;
            }

            nextNode = nextNode.next;
        }

    }

    /**
     * Checks if an appointment with given description exists.
     *
     * @param description The description of the appointment for which this
     * method finds out if it exists. Each description is unique for
     * appointments on the same day.
     *
     * @return Returns true if an appointment with given description exists.
     */
    public boolean containsAppointmentWithDescription(String description) {
        //TODO
        Node<Appointment> listOfAppointments = appointments.next;

        do {

            if (listOfAppointments.item.getDescription().equals(description)) {
                return true;
            }

            listOfAppointments = listOfAppointments.next;
        } while (listOfAppointments != null);

        return false;
    }

    /**
     * This method finds all start times that are available on this day for an
     * appointment of given duration.
     *
     * @param duration the requested duration for an appointment
     * @return an array of start times on which an appointment can be scheduled
     */
    public Time[] getAvailableStartTimesForAppointmentsOfDuration(TimeSpan duration) {

        TimeGap[] timegaps = new TimeGap[nrOfAppointments + 1];
        // 
        timegaps = this.getAvailableTimeGaps();
        Time[] times = new Time[timegaps.length];
        int counter = 0;
        
        for (TimeGap timegap : timegaps) {
            // checking if duration fits in the timegaps
            if (duration.getTimeSpanInMinutes() <= timegap.getLength().getTimeSpanInMinutes()) {
                times[counter++] = timegap.getStart();
            }
        }
        // get an array without null values
        Time[] restTime = Arrays.copyOf(times, counter);

        return restTime;
    }

    // METHODS INTRODUCED IN WEEK 4 OF APPOINTMENT PROJECT
    /**
     * This method gives a list of available time gaps on this day. Each time
     * gap holds the available time between appointments, and possibly at the
     * begin and at the end of the day.
     *
     * @return an array of TimeGaps containing all available time slots that are
     * available on this day.
     */
    public TimeGap[] getAvailableTimeGaps() {
        //TODO
        int counter = 0;
        TimeGap[] timegaps = new TimeGap[nrOfAppointments+1];
        Time start;
        Time end;

        for (Node<Appointment> i = appointments.next; i.next != null; i = i.next) {

            // if the end of firstAppoinment is before the start of the next Appoitment 
            if (i.item.getEnd().isBefore(i.next.item.getStart())) {
                start = i.item.getEnd();
                end = i.next.item.getStart();
                // create a new TimeGap
                timegaps[counter++] = new TimeGap(start, end);
            }
        }
        
       // ohly add so many timegaps like there are
       return Arrays.copyOf(timegaps, counter);
    }

    /**
     * get All currentAppoitnment in a Queue
     * @return Queue with Appointments 
     */
    public Queue<Appointment> getAppointments() {

        Queue<Appointment> q = new Queue();
        Node<Appointment> newNode = appointments;

        while (newNode.next != null) {
            // only put appointmens which priority are not NOTOUCH 
            if (newNode.next.item.getPriority() != Priority.NOTOUCH)
                q.put(newNode.next.item);

            newNode = newNode.next;
        }
        return q;
    }

    /**
     *  get Appointmens of a specific Priority 
     * @param priority Priority of a Appointment
     * @return  Stack of Appointment of the same Priority
     */
    public Stack getAppointmentsOfPriority(Priority priority) {
        Stack firstStack = new Stack();
        Stack secondStack = new Stack();

        Node<Appointment> newNode = appointments.next;

        while (newNode.next != null) {

            // if appoinemnt equals Priority put in stack
            if (priority.equals(newNode.item.getPriority())) {
                firstStack.push(newNode.item);
            }
            newNode = newNode.next;
        }

        // switch them over to the correct order
        while (firstStack.size() != 0) {
            secondStack.push(firstStack.pop());
        }

        return secondStack;

    }
}
