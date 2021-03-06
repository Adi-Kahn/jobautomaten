<?php 
/* 	
If you see this text in your browser, PHP is not configured correctly on this hosting provider. 
Contact your hosting provider regarding PHP configuration for your site.

PHP file generated by Adobe Muse CC 2015.1.2.344
*/

require_once('form_process.php');

$form = array(
	'subject' => 'Indsendelse af NYHEDSBREV',
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
		'custom_U560' => array(
			'order' => 1,
			'type' => 'string',
			'label' => 'Name',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'Name\' er påkrævet.'
			)
		),
		'Email' => array(
			'order' => 2,
			'type' => 'email',
			'label' => 'Email',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'Email\' er påkrævet.',
				'format' => 'Feltet \'Email\' har en ugyldig e-mailadresse.'
			)
		)
	)
);

process_form($form);
?>
