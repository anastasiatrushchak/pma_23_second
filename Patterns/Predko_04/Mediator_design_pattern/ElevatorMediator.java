package org.example.Predko_04.Mediator_design_pattern;

public class ElevatorMediator {
    private int currentFloor;

    public void pressButton(int floor) {
        this.currentFloor = floor;
        System.out.println("Ліфт викликано на поверх " + floor + ".");
    }

    public int getCurrentFloor() {
        return currentFloor;
    }
}
