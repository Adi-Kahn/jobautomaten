<?php 
/* 	
If you see this text in your browser, PHP is not configured correctly on this hosting provider. 
Contact your hosting provider regarding PHP configuration for your site.

PHP file generated by Adobe Muse CC 2015.1.2.344
*/

require_once('form_process.php');

$form = array(
	'subject' => 'Indsendelse af Mads - 30 år - KBH formular',
	'heading' => 'Ny formularindsendelse',
	'success_redirect' => '',
	'resources' => array(
		'checkbox_checked' => 'Markeret',
		'checkbox_unchecked' => 'Ikke markeret',
		'submitted_from' => 'Formular indsendt fra website: %s',
		'submitted_by' => 'Besøgendes IP-adresse: %s',
		'too_many_submissions' => 'For mange nylige indsendelser fra denne IP',
		'failed_to_send_email' => 'Kunne ikke sende e-mail',
		'invalid_reCAPTCHA_private_key' => 'Ugyldig privat reCAPTCHA-nøgle.',
		'invalid_field_type' => 'Ukendt felttype \'%s\'.',
		'invalid_form_config' => 'Feltet \'%s\' har en ugyldig konfiguration.',
		'unknown_method' => 'Ukendt serveranmodningsmetode'
	),
	'email' => array(
		'from' => 'info@jobautomaten.dk',
		'to' => 'info@jobautomaten.dk'
	),
	'fields' => array(
		'custom_U23479' => array(
			'order' => 1,
			'type' => 'string',
			'label' => 'Navn',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'Navn\' er påkrævet.'
			)
		),
		'Email' => array(
			'order' => 2,
			'type' => 'email',
			'label' => 'E-mail',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'E-mail\' er påkrævet.',
				'format' => 'Feltet \'E-mail\' har en ugyldig e-mailadresse.'
			)
		),
		'custom_U23467' => array(
			'order' => 4,
			'type' => 'string',
			'label' => 'Meddelelse',
			'required' => false,
			'errors' => array(
			)
		),
		'custom_U23483' => array(
			'order' => 3,
			'type' => 'string',
			'label' => 'Virksomhed',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'Virksomhed\' er påkrævet.'
			)
		),
		'custom_U23463' => array(
			'order' => 5,
			'type' => 'string',
			'label' => 'Mobiltelefon',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'Mobiltelefon\' er påkrævet.'
			)
		)
	)
);

process_form($form);
?>
