<script>
	import Router from "svelte-spa-router";
	import wrap from 'svelte-spa-router/wrap';

	import { user } from './js/stores.js';
	import { navigateTo } from './js/helpers.js';

	// Route imports
	import Home from "./Home.svelte";
	import Calendar from "./calendar/Calendar.svelte";
	import MyHabits from "./habits/MyHabits.svelte";
	import CreateHabit from "./habits/CreateHabit.svelte";
	import PickHabits from "./habits/PickHabits.svelte";
	import Logout from './authentication/Logout.svelte';
	import NotFound from "./navigation/NotFound.svelte";
	import LeftNavBar from './navigation/LeftNavBar.svelte';
	import Today from './calendar/Today.svelte';

	if (!window.location.hash) {
		navigateTo(window.location.pathname);
		window.location.pathname = "";
	}

	let currentUser;
	$: currentUser = $user

	const validateLogin = () => {
		return currentUser !== null;
	}

	const validateLoginFailed = () => {
		navigateTo("/");
	}

	// Define the route configuration
	const routes = {
		"/": Home,
		"/today": wrap({
			component: LeftNavBar,
			props: { component: Today },
			conditions: [() => {
			return validateLogin();
				}]
			}),
		"/calendar": wrap({
			component: LeftNavBar,
			props: { component: Calendar },
			conditions: [() => {
				return validateLogin();
			}]
		}),
		"/my-habits": wrap({
			component: LeftNavBar,
			props: { component: MyHabits },
			conditions: [() => {
				return validateLogin();
			}]
		}),
		"/edit-habit/:id": wrap({
			component: LeftNavBar,
			props: { component: CreateHabit },
			conditions: [() => {
				return validateLogin();
			}]
		}),
		"/create-habit": wrap({
			component: LeftNavBar,
			props: { component: CreateHabit },
			conditions: [() => {
				return validateLogin();
			}]
		}),
		"/pick-habits": wrap({
			component: LeftNavBar,
			props: { component: PickHabits },
			conditions: [() => {
				return validateLogin();
			}]
		}),
		"/logout": wrap({
			component: Logout,
			conditions: [() => {
				return validateLogin();
			}]
		}),
		"*": NotFound
	};
</script>

<Router {routes} on:conditionsFailed={validateLoginFailed} />