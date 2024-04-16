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
@Table(name = "Customer")
public class Customer {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "customer_id")
    private Long customerID;

    @Setter
    @Column(name = "number")
    private String customerNumber;

    @Setter
    @Column(name = "first_name")
    private String customerFirstName;

    @Setter
    @Column(name = "last_name")
    private String customerLastName;

    @Setter
    @Column(name = "license_id")
    private String customerLicenseId;

    @Setter
    @Column(name = "age")
    private int customerAge;

    @Setter
    @Column(name = "gender")
    private String customerGender;

    @OneToMany(mappedBy = "customer", cascade = CascadeType.REMOVE)
    private List<Agreement> agreements;
}
