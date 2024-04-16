package lnu.edu.ua.model.entity;

import jakarta.persistence.*;
import lombok.*;

import java.time.LocalDate;

@Entity
@Getter
@Setter
@Builder
@NoArgsConstructor
@AllArgsConstructor
@ToString
@Table(name = "Agreement")
public class Agreement {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "agreement_id")
    private Long agreementID;

    @Setter
    @Column(name = "start_date")
    private LocalDate startDate;

    @Setter
    @Column(name = "end_date")
    private LocalDate endDate;

    @Setter
    @Column(name = "cost_per_day")
    private Double costPerDay;

    @JoinColumn(name = "car_id")
    @ManyToOne(fetch = FetchType.LAZY)
    private Car car;

    @JoinColumn(name = "customer_id")
    @ManyToOne(fetch = FetchType.LAZY)
    private Customer customer;
}
