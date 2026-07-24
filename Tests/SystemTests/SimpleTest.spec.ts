import { test, expect } from '@playwright/test';

test('See first page', async ({ page }) => {
  await page.goto('/');

});