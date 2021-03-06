<?php 
/* 	
If you see this text in your browser, PHP is not configured correctly on this hosting provider. 
Contact your hosting provider regarding PHP configuration for your site.

PHP file generated by Adobe Muse CC 2015.1.2.344
*/

require_once('form_process.php');

$form = array(
	'subject' => 'Indsendelse af Indryk ny jobannonce formular',
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
			'order' => 10,
			'type' => 'email',
			'label' => 'E-mail',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'E-mail\' er påkrævet.',
				'format' => 'Feltet \'E-mail\' har en ugyldig e-mailadresse.'
			)
		),
		'custom_U26288' => array(
			'order' => 11,
			'type' => 'string',
			'label' => 'Annoncetekst',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'Annoncetekst\' er påkrævet.'
			)
		),
		'custom_U26364' => array(
			'order' => 6,
			'type' => 'string',
			'label' => 'Navn',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'Navn\' er påkrævet.'
			)
		),
		'custom_U26283' => array(
			'order' => 9,
			'type' => 'string',
			'label' => 'Adresse',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'Adresse\' er påkrævet.'
			)
		),
		'custom_U26334' => array(
			'order' => 7,
			'type' => 'string',
			'label' => 'Telefon',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'Telefon\' er påkrævet.'
			)
		),
		'custom_U26706' => array(
			'order' => 8,
			'type' => 'string',
			'label' => 'Stilling',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'Stilling\' er påkrævet.'
			)
		),
		'custom_U26718' => array(
			'order' => 5,
			'type' => 'string',
			'label' => 'Forventet start',
			'required' => true,
			'errors' => array(
				'required' => 'Feltet \'Forventet start\' er påkrævet.'
			)
		),
		'custom_U26342' => array(
			'order' => 4,
			'type' => 'checkboxgroup',
			'label' => 'Jobbet kræver',
			'required' => true,
			'optionItems' => array(
				'Kørekort',
				'Stort kørekort',
				'Flydende dansk'
			),
			'errors' => array(
				'required' => 'Feltet \'Jobbet kræver\' er påkrævet.',
				'format' => 'Feltet \'Jobbet kræver\' har en ugyldig værdi.'
			)
		),
		'custom_U26301' => array(
			'order' => 2,
			'type' => 'checkboxgroup',
			'label' => 'Hvilken kategori?',
			'required' => false,
			'optionItems' => array(
				'Informationsteknologi',
				'Ingeniør og teknik',
				'Ledelse og personale',
				'Handel og service',
				'Industri og håndværk',
				'Salg og kommunikation',
				'Undervisning',
				'Kontor og økonomi',
				'Social og sundhed',
				'Andet'
			),
			'errors' => array(
				'format' => 'Feltet \'Hvilken kategori?\' har en ugyldig værdi.'
			)
		),
		'custom_U26230' => array(
			'order' => 3,
			'type' => 'checkboxgroup',
			'label' => 'Jobtype',
			'required' => true,
			'optionItems' => array(
				'Fuldtid',
				'Praktik',
				'Fleksjob',
				'Vikar',
				'Deltid',
				'Løntilskud',
				'Pensionist job',
				'Elevplads/læreplads',
				'Besøgsven',
				'Frivillig'
			),
			'errors' => array(
				'required' => 'Feltet \'Jobtype\' er påkrævet.',
				'format' => 'Feltet \'Jobtype\' har en ugyldig værdi.'
			)
		),
		'custom_U26245' => array(
			'order' => 1,
			'type' => 'checkboxgroup',
			'label' => 'I hvilken region/er?',
			'required' => true,
			'optionItems' => array(
				'Københavnsområdet',
				'Region Sjælland',
				'Midtjylland',
				'Fyn',
				'Sydjylland',
				'Nordjylland',
				'Bornholm',
				'Andet'
			),
			'errors' => array(
				'required' => 'Feltet \'I hvilken region/er?\' er påkrævet.',
				'format' => 'Feltet \'I hvilken region/er?\' har en ugyldig værdi.'
			)
		)
	)
);

process_form($form);
?>
