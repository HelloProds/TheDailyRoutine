<script>
	import { onMount } from 'svelte';

	import { user } from './js/stores.js';
	import { navigateTo } from './js/helpers.js';

	import Login from "./authentication/Login.svelte";
	import Register from "./authentication/Register.svelte";

	let showRegister = false;

	let currentUser;
	$: currentUser = $user;

	const toggleForm = () => {
		showRegister = !showRegister;
	};

	onMount(() => {
		if (currentUser) {
			navigateTo("/today")
		}
	})
</script>

<div class="fullscreen-container">
	<div class="glow"></div>
	<div class="glow glow-2"></div>

	<div class="card">
		{#if showRegister}
			<h1 class="title">Welcome</h1>
			<p class="description">
				Register to start tracking your habits and improving your daily routine.
			</p>
		{:else}
			<h1 class="title">Welcome Back</h1>
			<p class="description">
				Log in to continue tracking your habits and improving your daily routine.
			</p>
		{/if}

		<div class="form-container">
			{#if showRegister}
				<Register />
				<p class="toggle-link">
					Already have an account?
					<a href="#/" on:click|preventDefault={toggleForm}>Log in here</a>
				</p>
			{:else}
				<Login />
				<p class="toggle-link">
					Don't have an account?
					<a href="#/" on:click|preventDefault={toggleForm}>Register here</a>
				</p>
			{/if}
		</div>
	</div>
</div>

<style>
    .fullscreen-container {
        width: 100%;
        height: 100vh;
        background-color: #121212;
        display: flex;
        align-items: center;
        justify-content: center;
    }

    .glow,
    .glow-2 {
        position: absolute;
        top: -10%;
        left: -10%;
        width: 120%;
        height: 120%;
        background: radial-gradient(circle, rgba(59, 130, 246, 0.5) 10%, transparent 80%);
        border-radius: 50%;
        filter: blur(80px);
        animation: moveCurves 8s linear infinite alternate;
    }

    .glow-2 {
        top: auto;
        left: auto;
        bottom: -10%;
        right: -10%;
        animation-delay: 2s;
    }

    @keyframes moveCurves {
        0% {
            transform: translateY(-20%) translateX(0) scale(1);
        }
        100% {
            transform: translateY(20%) translateX(10%) scale(1.1);
        }
    }

    .card {
        background-color: #1e1e1e;
        padding: 2.5rem;
        border-radius: 8px;
        box-shadow: 0 4px 16px rgba(0, 0, 0, 0.6);
        max-width: 30rem;
        text-align: center;
        z-index: 2;
    }

    .title {
        margin-bottom: 1rem;
    }

    .description {
        color: #b0b0b0;
        margin-bottom: 1.5rem;
    }

	.toggle-link {
			margin-top: 1rem;
	}

    .toggle-link a {
        color: #60a5fa;
        text-decoration: none;
        font-weight: bold;
    }

    .toggle-link a:hover {
        text-decoration: underline;
    }
</style>
