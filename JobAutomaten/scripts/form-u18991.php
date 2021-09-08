<?php 
/* 	
If you see this text in your browser, PHP is not configured correctly on this hosting provider. 
Contact your hosting provider regarding PHP configuration for your site.

PHP file generated by Adobe Muse CC 2015.1.2.344
*/

require_once('form_process.php');

$form = array(
	'subject' => 'Indsendelse af Opret CV formular',
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
		'Email' => array(
			'order' => 11,
			'type' => 'email',
			'label' => 'E-mail',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'E-mail\' er påkrævet.',
				'format' => 'Feltet \'E-mail\' har en ugyldig e-mailadresse.'
			)
		),
		'custom_U18992' => array(
			'order' => 1,
			'type' => 'string',
			'label' => 'Vælg område',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'Vælg område\' er påkrævet.'
			)
		),
		'custom_U19028' => array(
			'order' => 7,
			'type' => 'string',
			'label' => 'Tidligere arbejde',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'Tidligere arbejde\' er påkrævet.'
			)
		),
		'custom_U19020' => array(
			'order' => 3,
			'type' => 'string',
			'label' => 'Særlige forhold?',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'Særlige forhold?\' er påkrævet.'
			)
		),
		'custom_U19016' => array(
			'order' => 12,
			'type' => 'string',
			'label' => 'Profiltekst',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'Profiltekst\' er påkrævet.'
			)
		),
		'custom_U19024' => array(
			'order' => 8,
			'type' => 'string',
			'label' => 'Erhvervserfaring',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'Erhvervserfaring\' er påkrævet.'
			)
		),
		'custom_U19011' => array(
			'order' => 10,
			'type' => 'string',
			'label' => 'Adresse',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'Adresse\' er påkrævet.'
			)
		),
		'custom_U19057' => array(
			'order' => 9,
			'type' => 'string',
			'label' => 'Telefon',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'Telefon\' er påkrævet.'
			)
		),
		'custom_U19041' => array(
			'order' => 4,
			'type' => 'checkboxgroup',
			'label' => 'Jobtype',
			'required' => true,
			'optionItems' => array(
				'Alm',
				'Praktik',
				'Fleks',
				'Deltid'
			),
			'errors' => array(
				'required' => 'Feltet \'Jobtype\' er påkrævet.',
				'format' => 'Feltet \'Jobtype\' har en ugyldig værdi.'
			)
		),
		'custom_U19032' => array(
			'order' => 2,
			'type' => 'checkboxgroup',
			'label' => 'Ekstra',
			'required' => true,
			'optionItems' => array(
				'Kørekort',
				'Uddannelse'
			),
			'errors' => array(
				'required' => 'Feltet \'Ekstra\' er påkrævet.',
				'format' => 'Feltet \'Ekstra\' har en ugyldig værdi.'
			)
		),
		'custom_U18997' => array(
			'order' => 6,
			'type' => 'checkboxgroup',
			'label' => 'Køn',
			'required' => false,
			'optionItems' => array(
				'Mand',
				'Kvinde'
			),
			'errors' => array(
				'format' => 'Feltet \'Køn\' har en ugyldig værdi.'
			)
		),
		'custom_U19061' => array(
			'order' => 5,
			'type' => 'checkboxgroup',
			'label' => 'Hvad vil du gerne arbejde med?',
			'required' => false,
			'optionItems' => array(
				'Informationsteknologi',
				'Ingeniør og teknik',
				'Ledelse og personale',
				'Handel og service',
				'Industri og håndværk',
				'Salg og kommunikation',
				'Undervisning',
				'Kontor og økonimo',
				'Social og sundhed',
				'Andet'
			),
			'errors' => array(
				'format' => 'Feltet \'Hvad vil du gerne arbejde med?\' har en ugyldig værdi.'
			)
		)
	)
);

process_form($form);
?>