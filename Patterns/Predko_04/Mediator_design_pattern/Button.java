package org.example.Predko_04.Mediator_design_pattern;

public class Button {
    private ElevatorMediator mediator;
    private int floor;

    public Button(ElevatorMediator mediator, int floor) {
        this.mediator = mediator;
        this.floor = floor;
    }

    public void press() {
        mediator.pressButton(floor);
    }
}
