package com.example.contact.entity;

import jakarta.persistence.;
import lombok.;

@Entity
@Data
@NoArgsConstructor
@AllArgsConstructor
public class ContactForm {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String name;
    private String email;
    private String message;
}