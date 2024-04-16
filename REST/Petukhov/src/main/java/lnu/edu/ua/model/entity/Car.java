package lnu.edu.ua.model.entity;

import jakarta.persistence.*;
import lombok.*;

import java.util.List;

@Entity
@Getter
@Setter
@Builder
@AllArgsConstructor
@NoArgsConstructor
@ToString
@Table(name = "Car")
public class Car {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "car_id")
    private Long carID;

    @Setter
    @Column(name = "number")
    private String carNumber;

    @Setter
    @Column(name = "brand")
    private String carBrand;

    @Setter
    @Column(name = "type")
    private String carType;

    @Setter
    @Column(name = "color")
    private String carColor;

    @Setter
    @Column(name = "seats")
    private int carSeats;

    @Setter
    @Column(name = "manufacturer")
    private String carManufacturer;

    @OneToMany(mappedBy = "car", cascade = CascadeType.REMOVE)
    private List<Agreement> users;
}
