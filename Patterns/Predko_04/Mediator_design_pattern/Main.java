package org.example.Predko_04.Mediator_design_pattern;

public class Main {
    public static void main(String[] args) {
        ElevatorMediator elevatorMediator = new ElevatorMediator();
        Button button5thFloor = new Button(elevatorMediator, 5);
        button5thFloor.press();
        System.out.println("Ліфт знаходиться на поверсі " + elevatorMediator.getCurrentFloor() + ".");
    }
}